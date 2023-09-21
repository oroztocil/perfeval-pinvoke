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

def make_barplot(input_df: pd.DataFrame, category: str | None, unit: str, title: str):
    category_df = input_df if category is None else input_df.query(f"Category == '{category}'")
    grouped_df = category_df.groupby(["Target_Type", "Target_Method", "Job_Runtime"])

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

        for val in data["Measurement_Value"].to_list():
            items.append({
                "Type": type,
                "Runtime": runtime_version,
                "Value": val if unit == "ns" else val / 1000.0 / 1000.0,
                "Order": order_map[type],
                "Color": color_map[type]
            })

    items.sort(key=lambda x: x["Order"])

    method_total = sum(map(len, methods.values()))
    method_ratios = list(map(lambda x: len(x) / method_total, methods.values()))

    input_df = pd.DataFrame(items)

    fig, ax = plt.subplots(1, 3, sharey=True, gridspec_kw={'width_ratios': method_ratios})
    fig.suptitle(title, fontsize=16, fontweight="bold")
    fig.supylabel(f"Mean execution time ({unit})", fontsize=12)

    for i, runtime in [(0, ".NET 4.8"), (1, ".NET 6.0"), (2, ".NET 8.0")]:
        _df = input_df[input_df.Runtime == runtime]
        sns.barplot(
            ax=ax[i],
            data=_df,
            x="Type", y="Value",
            palette=color_map,
            saturation=1.0
        )

        ax[i].bar_label(ax[i].containers[0], fmt='%.2f', label_type="center")
        ax[i].set_xlabel("")
        ax[i].set_ylabel("")
        ax[i].set_title(runtime, fontsize=12)

    plt.show()


def main(argv):
    input_df = load_results_file(argv[0])
    make_barplot(input_df, argv[1], argv[2], argv[3])


if __name__ == "__main__":
    main(sys.argv[1:])
