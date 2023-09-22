import glob
from matplotlib import pyplot as plt
import pandas as pd
import seaborn as sns
import sys

color_map = dict(zip(
    ["Managed", "DllImport", "LibraryImport", "FuncPointers"],
    ["#79ccb3","#e9724d", "#d6d727", "#92cad1", ]
))

order_map = dict(zip(
    ["Managed", "DllImport", "LibraryImport", "FuncPointers"],
    [10, 20, 30, 40]
))


def load_results_file(run_dir: str) -> pd.DataFrame:
    results_dir = run_dir + "/results"
    file = glob.glob(results_dir + "/*measurements.csv")[0]
    df = pd.read_csv(file, delimiter=";")
    return df

def merge_results_files(root_dir: str) -> pd.DataFrame:
    files = glob.glob(root_dir + "*/results/*measurements.csv")
    result = pd.DataFrame()
    for file in files:
        df = pd.read_csv(file, delimiter=";")
        result = pd.concat([result, df])
    return result

def make_barplot(input_df: pd.DataFrame, title, unit, category = None, param = None, figsize = (14, 6)):
    category_df = input_df if category is None else input_df.query(f"Category == '{category}'")
    param_df = category_df if param is None else category_df.query(f"Params == '{param}'")
    grouped_df = param_df.groupby(["Target_Type", "Target_Method", "Job_Runtime"])

    items = []
    methods = {
        ".NET 4.8": set(),
        ".NET 6.0": set(),
        ".NET 8.0": set(),
    }

    for keys, data in grouped_df:
        (type, method, runtime) = keys
        runtime_version = ".NET " + runtime.split(" ")[-1]
        case = f"{type}-{method}"
        methods[runtime_version].add(case)

        method_parts = method.split("_")
        bar = type if len(method_parts) < 2 else f"{type}\n({method_parts[-1]})"
        color_map[bar] = color_map[type]

        for val in data["Measurement_Value"].to_list():
            items.append({
                "Type": bar,
                "Runtime": runtime_version,
                "Value": val if unit == "ns" else val / 1000.0 / 1000.0,
                "Order": order_map[type],
                "Color": color_map[type]
            })

    items.sort(key=lambda x: x["Order"])

    method_total = sum(map(len, methods.values()))
    method_ratios = list(filter(lambda x: x > 0, map(lambda x: len(x) / method_total, methods.values())))
    
    used_runtimes = list(filter(lambda kv: len(kv[1]) > 0, methods.items()))
    runtime_plot_info = list(zip(used_runtimes, range(0, len(used_runtimes))))

    input_df = pd.DataFrame(items)

    fig, ax = plt.subplots(1, len(runtime_plot_info), figsize=figsize, sharey=True, gridspec_kw={'width_ratios': method_ratios})
    fig.suptitle(title, fontsize=16, fontweight="bold")
    fig.supylabel(f"Mean execution time ({unit})", fontsize=12)

    for ((runtime, mets), i) in runtime_plot_info:
        _df = input_df[input_df.Runtime == runtime]
        plot = sns.barplot(
            ax=ax[i],
            data=_df,
            x="Type", y="Value",
            palette=color_map,
            saturation=1.0
        )

        if method_total > 10:
            plot.set_xticklabels(plot.get_xticklabels(), rotation=45, fontsize=9)

        ax[i].bar_label(ax[i].containers[0], fmt='%.2f', label_type="center")
        ax[i].set_xlabel("")
        ax[i].set_ylabel("")
        ax[i].set_title(runtime, fontsize=12)

    plt.show()


def main(args):    
    # input_df = load_results_file(args[0])
    # unit = args[1]
    # title = args[2]
    # category = None if len(args) < 4 else args[3]
    # make_barplot(input_df, category, unit, title)
    # df = merge_results_files("ColdResults/CS_Mixed1")
    df = load_results_file("../ReportData/Arrays_InOut_2023-09-21T00_45_32")
    make_barplot(df, "Arrays In Out", "ns")

if __name__ == "__main__":
    main(sys.argv[1:])
