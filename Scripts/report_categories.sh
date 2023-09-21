#!/bin/bash

bash run_category.sh Void_Empty
# bash run_category.sh Arrays_Empty_In
# bash run_category.sh Strings_Empty_In
# bash run_category.sh Primitive_Int_Out
# bash run_category.sh Primitive_Int_InOut
# bash run_category.sh Primitive_Bool_InOut
# bash run_category.sh Arrays_In
# bash run_category.sh Arrays_InOut
# bash run_category.sh Strings_In
# bash run_category.sh Strings_InOut
# bash run_category.sh Structs_Blittable
# bash run_category.sh Structs_NonBlittable


CS_RUNS=25
# bash cold_start.sh CS_Void_Empty CS_Void_Empty ${CS_RUNS}
# bash cold_start.sh CS_Strings_Empty_In CS_Strings_Empty_In ${CS_RUNS}
# bash cold_start.sh CS_Arrays_InOut CS_Arrays_InOut ${CS_RUNS}
# bash cold_start.sh CS_Structs_Blittable CS_Structs_Blittable ${CS_RUNS}
bash cold_start.sh CS_Structs_NonBlittable CS_Structs_NonBlittable ${CS_RUNS}
# bash cold_start.sh CS_Mixed CS_Mixed ${CS_RUNS}

bash run_category.sh SGCT
bash run_category.sh SUCS
# bash run_category.sh SLE

