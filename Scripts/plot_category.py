import glob
import pandas as pd
import sys

def get_results_file(run_dir: str):
    results_dir = run_dir + "/results"
    file = glob.glob(results_dir + "/*measurements.csv")[0]
    return file

def main(argv):
    results_file = get_results_file(argv[0])
    df = pd.read_csv(results_file)
    print(df)

    
if __name__ == "__main__":
   main(sys.argv[1:])
