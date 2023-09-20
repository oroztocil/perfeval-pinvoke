#!/bin/bash

set -x

if [ $# -eq 0 ]
    then
        echo "Provide benchmark category to run"
        exit 1
fi

CATEGORY=$1
SCRIPT_DIR=$( cd -- "$( dirname -- "${BASH_SOURCE[0]}" )" &> /dev/null && pwd )

dotnet run --project ${SCRIPT_DIR}/../PInvoke.Benchmarks -c Release -f net8.0 --anyCategories=${CATEGORY} --join

# dotnet run --project ../PInvoke.Benchmarks -c Release -f net8.0 --join