#!/bin/bash

if [ $# -lt 3 ]
    then
        echo "Provide benchmark category, run label, and launch count"
        exit 1
fi

CATEGORY=$1
LABEL=$2
N=$3

SCRIPT_DIR=$( cd -- "$( dirname -- "${BASH_SOURCE[0]}" )" &> /dev/null && pwd )

for (( i=1; i<=$N; i++ ))
do
    echo "== LAUNCH $i =="
    dotnet run --project ${SCRIPT_DIR}/../PInvoke.Benchmarks -c Release -f net8.0 --anyCategories=${CATEGORY} --artifacts="ColdResults/${LABEL}"
done