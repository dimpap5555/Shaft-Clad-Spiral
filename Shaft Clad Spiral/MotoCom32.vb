Imports System
Imports System.Runtime.InteropServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace WindowsApplication1
	' Token: 0x02000013 RID: 19
	Friend NotInheritable Module MotoCom32
		' Token: 0x0600037E RID: 894
		Public Declare Ansi Function BscCancel Lib "MotoCom32" Alias "_BscCancel@4" (nCid As Short) As Short

		' Token: 0x0600037F RID: 895
		Public Declare Ansi Function BscChangeTask Lib "MotoCom32" Alias "_BscChangeTask@8" (nCid As Short, task As Short) As Short

		' Token: 0x06000380 RID: 896
		Public Declare Ansi Function BscClose Lib "MotoCom32" Alias "_BscClose@4" (nCid As Short) As Short

		' Token: 0x06000381 RID: 897
		Public Declare Ansi Function BscCommand Lib "MotoCom32" Alias "_BscCommand@16" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef h_buf As String, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef d_buf As String, fforever As Short) As Short

		' Token: 0x06000382 RID: 898
		Public Declare Ansi Function BscConnect Lib "MotoCom32" Alias "_BscConnect@4" (nCid As Short) As Short

		' Token: 0x06000383 RID: 899
		Public Declare Ansi Function BscContinueJob Lib "MotoCom32" Alias "_BscContinueJob@4" (nCid As Short) As Short

		' Token: 0x06000384 RID: 900
		Public Declare Ansi Function BscConvertJobP2R Lib "MotoCom32" Alias "_BscConvertJobP2R@12" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef name_v As String, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef framename As String) As Short

		' Token: 0x06000385 RID: 901
		Public Declare Ansi Function BscConvertJobR2P Lib "MotoCom32" Alias "_BscConvertJobR2P@16" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef name_v As String, cv_type As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef var_no As String) As Short

		' Token: 0x06000386 RID: 902
		Public Declare Ansi Function BscDCIGetPos Lib "MotoCom32" Alias "_BscDCIGetPos@16" (nCid As Short, ByRef type_v As Short, ByRef rconf As Short, ByRef p As Double) As Short

		' Token: 0x06000387 RID: 903
		Public Declare Ansi Function BscDCIGetPos2 Lib "MotoCom32" Alias "_BscDCIGetPos2@20" (nCid As Short, ByRef type_v As Short, ByRef rconf As Short, ByRef p As Double, ByRef axisNum As Short) As Short

		' Token: 0x06000388 RID: 904
		Public Declare Ansi Function BscDCIGetVarData Lib "MotoCom32" Alias "_BscDCIGetVarData@20" (nCid As Short, ByRef type_v As Short, ByRef rconf As Short, ByRef p As Double, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef s As String) As Short

		' Token: 0x06000389 RID: 905
		Public Declare Ansi Function BscDCIGetVarDataEx Lib "MotoCom32" Alias "_BscDCIGetVarDataEx@24" (nCid As Short, ByRef type_v As Short, ByRef rconf As Integer, ByRef p As Double, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef s As String, ByRef axisNum As Short) As Short

		' Token: 0x0600038A RID: 906
		Public Declare Ansi Function BscDCILoadSave Lib "MotoCom32" Alias "_BscDCILoadSave@8" (nCid As Short, timec As Short) As Short

		' Token: 0x0600038B RID: 907
		Public Declare Ansi Function BscDCILoadSaveOnce Lib "MotoCom32" Alias "_BscDCILoadSaveOnce@4" (nCid As Short) As Short

		' Token: 0x0600038C RID: 908
		Public Declare Ansi Function BscDCIPutPos Lib "MotoCom32" Alias "_BscDCIPutPos@16" (nCid As Short, type_v As Short, rconf As Short, ByRef p As Double) As Short

		' Token: 0x0600038D RID: 909
		Public Declare Ansi Function BscDCIPutPos2 Lib "MotoCom32" Alias "_BscDCIPutPos2@20" (nCid As Short, type_v As Short, rconf As Short, ByRef p As Double, axisNum As Short) As Short

		' Token: 0x0600038E RID: 910
		Public Declare Ansi Function BscDCIPutVarData Lib "MotoCom32" Alias "_BscDCIPutVarData@20" (nCid As Short, type_v As Short, rconf As Short, ByRef p As Double, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef s As String) As Short

		' Token: 0x0600038F RID: 911
		Public Declare Ansi Function BscDCIPutVarDataEx Lib "MotoCom32" Alias "_BscDCIPutVarDataEx@24" (nCid As Short, type_v As Short, rconf As Integer, ByRef p As Double, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef s As String, axisNum As Short) As Short

		' Token: 0x06000390 RID: 912
		Public Declare Ansi Function BscDeleteJob Lib "MotoCom32" Alias "_BscDeleteJob@4" (nCid As Short) As Short

		' Token: 0x06000391 RID: 913
		Public Declare Ansi Function BscDisConnect Lib "MotoCom32" Alias "_BscDisConnect@4" (nCid As Short) As Short

		' Token: 0x06000392 RID: 914
		Public Declare Ansi Function BscDiskFreeSizeGet Lib "MotoCom32" Alias "_BscDiskFreeSizeGet@12" (nCid As Short, dno As Short, ByRef dsize As Integer) As Short

		' Token: 0x06000393 RID: 915
		Public Declare Ansi Function BscDownLoad Lib "MotoCom32" Alias "_BscDownLoad@8" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef fname As String) As Short

		' Token: 0x06000394 RID: 916
		Public Declare Ansi Function BscDownLoadEx Lib "MotoCom32" Alias "_BscDownLoadEx@16" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef fname As String, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef srcPath As String, nFlg As Boolean) As Short

		' Token: 0x06000395 RID: 917
		Public Declare Ansi Function BscEnforcedClose Lib "MotoCom32" Alias "_BscEnforcedClose@4" (nCid As Short) As Short

		' Token: 0x06000396 RID: 918
		Public Declare Ansi Function BscFindFirst Lib "MotoCom32" Alias "_BscFindFirst@12" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef fname As String, size As Short) As Short

		' Token: 0x06000397 RID: 919
		Public Declare Ansi Function BscFindFirstMaster Lib "MotoCom32" Alias "_BscFindFirstMaster@12" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef fname As String, size As Short) As Short

		' Token: 0x06000398 RID: 920
		Public Declare Ansi Function BscFindNext Lib "MotoCom32" Alias "_BscFindNext@12" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef fname As String, size As Short) As Short

		' Token: 0x06000399 RID: 921
		Public Declare Ansi Function BscFindNextMaster Lib "MotoCom32" Alias "_BscFindNextMaster@12" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef fname As String, size As Short) As Short

		' Token: 0x0600039A RID: 922
		Public Declare Ansi Function BscGetCartPos Lib "MotoCom32" Alias "_BscGetCartPos@24" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef framename As String, isex As Short, ByRef rconf As Integer, ByRef toolno As Short, ByRef p As Double) As Short

		' Token: 0x0600039B RID: 923
		Public Declare Ansi Function BscGetCtrlGroup Lib "MotoCom32" Alias "_BscGetCtrlGroup@12" (nCid As Short, ByRef groupinf As Short, ByRef taskinf As Short) As Short

		' Token: 0x0600039C RID: 924
		Public Declare Ansi Function BscGetCtrlGroupDx Lib "MotoCom32" Alias "_BscGetCtrlGroupDx@16" (nCid As Short, ByRef robtask As Integer, ByRef stattask As Integer, ByRef taskinf As Short) As Short

		' Token: 0x0600039D RID: 925
		Public Declare Ansi Function BscGetCtrlGroupXrc Lib "MotoCom32" Alias "_BscGetCtrlGroupXrc@16" (nCid As Short, ByRef robtask As Short, ByRef stattask As Short, ByRef taskinf As Short) As Short

		' Token: 0x0600039E RID: 926
		Public Declare Ansi Function BscGetError Lib "MotoCom32" Alias "_BscGetError@4" (nCid As Short) As Short

		' Token: 0x0600039F RID: 927
		Public Declare Ansi Function BscGetError2 Lib "MotoCom32" Alias "_BscGetError2@4" (nCid As Short) As Short

		' Token: 0x060003A0 RID: 928
		Public Declare Ansi Function BscGetFirstAlarm Lib "MotoCom32" Alias "_BscGetFirstAlarm@8" (nCid As Short, ByRef data_v As Short) As Short

		' Token: 0x060003A1 RID: 929
		Public Declare Ansi Function BscGetFirstAlarmS Lib "MotoCom32" Alias "_BscGetFirstAlarmS@12" (nCid As Short, ByRef data_v As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef s As String) As Short

		' Token: 0x060003A2 RID: 930
		Public Declare Ansi Function BscGetNextAlarm Lib "MotoCom32" Alias "_BscGetNextAlarm@8" (nCid As Short, ByRef data_v As Short) As Short

		' Token: 0x060003A3 RID: 931
		Public Declare Ansi Function BscGetNextAlarmS Lib "MotoCom32" Alias "_BscGetNextAlarmS@12" (nCid As Short, ByRef data_v As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef s As String) As Short

		' Token: 0x060003A4 RID: 932
		Public Declare Ansi Function BscGetPulsePos Lib "MotoCom32" Alias "_BscGetPulsePos@8" (nCid As Short, ByRef p As Double) As Short

		' Token: 0x060003A5 RID: 933
		Public Declare Ansi Function BscGets Lib "MotoCom32" Alias "_BscGets@16" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef bufptr As String, bsize As Short, ByRef plengets As Short) As Short

		' Token: 0x060003A6 RID: 934
		Public Declare Ansi Function BscGetStatus Lib "MotoCom32" Alias "_BscGetStatus@12" (nCid As Short, ByRef d1 As Short, ByRef d2 As Short) As Short

		' Token: 0x060003A7 RID: 935
		Public Declare Ansi Function BscGetUFrame Lib "MotoCom32" Alias "_BscGetUFrame@12" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef ufname As String, ByRef p As Double) As Short

		' Token: 0x060003A8 RID: 936
		Public Declare Ansi Function BscGetVarData Lib "MotoCom32" Alias "_BscGetVarData@16" (nCid As Short, type_v As Short, varno As Short, ByRef pos As Double) As Short

		' Token: 0x060003A9 RID: 937
		Public Declare Ansi Function BscGetVarData2 Lib "MotoCom32" Alias "_BscGetVarData2@16" (nCid As Short, type_v As Short, varno As Short, ByRef pos As Double) As Short

		' Token: 0x060003AA RID: 938
		Public Declare Ansi Function BscGetVarDataEx Lib "MotoCom32" Alias "_BscGetVarDataEx@24" (nCid As Short, type_v As Short, varno As Short, ByRef pos As Double, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef s As String, ByRef axisNum As Short) As Short

		' Token: 0x060003AB RID: 939
		Public Declare Ansi Function BscHoldOff Lib "MotoCom32" Alias "_BscHoldOff@4" (nCid As Short) As Short

		' Token: 0x060003AC RID: 940
		Public Declare Ansi Function BscHoldOn Lib "MotoCom32" Alias "_BscHoldOn@4" (nCid As Short) As Short

		' Token: 0x060003AD RID: 941
		Public Declare Ansi Function BscHostGetVarData Lib "MotoCom32" Alias "_BscHostGetVarData@20" (nCid As Short, type_v As Short, varno As Short, ByRef pos As Double, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef s As String) As Short

		' Token: 0x060003AE RID: 942
		Public Declare Ansi Function BscHostGetVarDataM Lib "MotoCom32" Alias "_BscHostGetVarDataM@20" (nCid As Short, type_v As Short, varno As Short, num As Short, ByRef pos As Double) As Short

		' Token: 0x060003AF RID: 943
		Public Declare Ansi Function BscHostPutVarData Lib "MotoCom32" Alias "_BscHostPutVarData@20" (nCid As Short, type_v As Short, varno As Short, ByRef dat As Double, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef s As String) As Short

		' Token: 0x060003B0 RID: 944
		Public Declare Ansi Function BscHostPutVarDataM Lib "MotoCom32" Alias "_BscHostPutVarDataM@20" (nCid As Short, type_v As Short, varno As Short, num As Short, ByRef dat As Double) As Short

		' Token: 0x060003B1 RID: 945
		Public Declare Ansi Function BscImov Lib "MotoCom32" Alias "_BscImov@28" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef vtype As String, spd As Double, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef framename As String, toolno As Short, ByRef p As Double) As Short

		' Token: 0x060003B2 RID: 946
		Public Declare Ansi Function BscImovEx Lib "MotoCom32" Alias "_BscImovEx@32" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef vtype As String, spd As Double, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef framename As String, toolno As Short, ByRef p As Double, axisNum As Short) As Short

		' Token: 0x060003B3 RID: 947
		Public Declare Ansi Function BscInBytes Lib "MotoCom32" Alias "_BscInBytes@4" (nCid As Short) As Short

		' Token: 0x060003B4 RID: 948
		Public Declare Ansi Function BscIsAlarm Lib "MotoCom32" Alias "_BscIsAlarm@4" (nCid As Short) As Short

		' Token: 0x060003B5 RID: 949
		Public Declare Ansi Function BscIsCtrlGroup Lib "MotoCom32" Alias "_BscIsCtrlGroup@4" (nCid As Short) As Short

		' Token: 0x060003B6 RID: 950
		Public Declare Ansi Function BscIsCtrlGroupDx Lib "MotoCom32" Alias "_BscIsCtrlGroupDx@12" (nCid As Short, ByRef robtask As Integer, ByRef stattask As Integer) As Short

		' Token: 0x060003B7 RID: 951
		Public Declare Ansi Function BscIsCtrlGroupXrc Lib "MotoCom32" Alias "_BscIsCtrlGroupXrc@12" (nCid As Short, ByRef robtask As Short, ByRef stattask As Short) As Short

		' Token: 0x060003B8 RID: 952
		Public Declare Ansi Function BscIsCycle Lib "MotoCom32" Alias "_BscIsCycle@4" (nCid As Short) As Short

		' Token: 0x060003B9 RID: 953
		Public Declare Ansi Function BscIsError Lib "MotoCom32" Alias "_BscIsError@4" (nCid As Short) As Short

		' Token: 0x060003BA RID: 954
		Public Declare Ansi Function BscIsErrorCode Lib "MotoCom32" Alias "_BscIsErrorCode@4" (nCid As Short) As Short

		' Token: 0x060003BB RID: 955
		Public Declare Ansi Function BscIsHold Lib "MotoCom32" Alias "_BscIsHold@4" (nCid As Short) As Short

		' Token: 0x060003BC RID: 956
		Public Declare Ansi Function BscIsJobLine Lib "MotoCom32" Alias "_BscIsJobLine@4" (nCid As Short) As Short

		' Token: 0x060003BD RID: 957
		Public Declare Ansi Function BscIsJobName Lib "MotoCom32" Alias "_BscIsJobName@12" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef jobname As String, size As Short) As Short

		' Token: 0x060003BE RID: 958
		Public Declare Ansi Function BscIsJobStep Lib "MotoCom32" Alias "_BscIsJobStep@4" (nCid As Short) As Short

		' Token: 0x060003BF RID: 959
		Public Declare Ansi Function BscIsLoc Lib "MotoCom32" Alias "_BscIsLoc@16" (nCid As Short, ispulse As Short, ByRef rconf As Short, ByRef p As Double) As Short

		' Token: 0x060003C0 RID: 960
		Public Declare Ansi Function BscIsPlayMode Lib "MotoCom32" Alias "_BscIsPlayMode@4" (nCid As Short) As Short

		' Token: 0x060003C1 RID: 961
		Public Declare Ansi Function BscIsRemoteMode Lib "MotoCom32" Alias "_BscIsRemoteMode@4" (nCid As Short) As Short

		' Token: 0x060003C2 RID: 962
		Public Declare Ansi Function BscIsRobotPos Lib "MotoCom32" Alias "_BscIsRobotPos@24" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef framename As String, isex As Short, ByRef rconf As Short, ByRef toolno As Short, ByRef p As Double) As Short

		' Token: 0x060003C3 RID: 963
		Public Declare Ansi Function BscIsServo Lib "MotoCom32" Alias "_BscIsServo@4" (nCid As Short) As Short

		' Token: 0x060003C4 RID: 964
		Public Declare Ansi Function BscIsTaskInf Lib "MotoCom32" Alias "_BscIsTaskInf@4" (nCid As Short) As Short

		' Token: 0x060003C5 RID: 965
		Public Declare Ansi Function BscIsTaskInfDx Lib "MotoCom32" Alias "_BscIsTaskInfDx@4" (nCid As Short) As Short

		' Token: 0x060003C6 RID: 966
		Public Declare Ansi Function BscIsTaskInfXrc Lib "MotoCom32" Alias "_BscIsTaskInfXrc@4" (nCid As Short) As Short

		' Token: 0x060003C7 RID: 967
		Public Declare Ansi Function BscIsTeachMode Lib "MotoCom32" Alias "_BscIsTeachMode@4" (nCid As Short) As Short

		' Token: 0x060003C8 RID: 968
		Public Declare Ansi Function BscJobWait Lib "MotoCom32" Alias "_BscJobWait@8" (nCid As Short, time As Short) As Short

		' Token: 0x060003C9 RID: 969
		Public Declare Ansi Function BscMDSP Lib "MotoCom32" Alias "_BscMDSP@8" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef ptr As String) As Short

		' Token: 0x060003CA RID: 970
		Public Declare Ansi Function BscMov Lib "MotoCom32" Alias "_BscMov@36" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef movtype As String, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef vtype As String, spd As Double, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef framename As String, rconf As Short, toolno As Short, ByRef p As Double) As Short

		' Token: 0x060003CB RID: 971
		Public Declare Ansi Function BscMovEx Lib "MotoCom32" Alias "_BscMovEx@40" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef movtype As String, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef vtype As String, spd As Double, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef framename As String, rconf As Integer, toolno As Short, ByRef p As Double, axisNum As Short) As Short

		' Token: 0x060003CC RID: 972
		Public Declare Ansi Function BscMovj Lib "MotoCom32" Alias "_BscMovj@28" (nCid As Short, spd As Double, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef framename As String, rconf As Short, toolno As Short, ByRef p As Double) As Short

		' Token: 0x060003CD RID: 973
		Public Declare Ansi Function BscMovjEx Lib "MotoCom32" Alias "_BscMovjEx@32" (nCid As Short, spd As Double, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef framename As String, rconf As Integer, toolno As Short, ByRef p As Double, axisNum As Short) As Short

		' Token: 0x060003CE RID: 974
		Public Declare Ansi Function BscMovl Lib "MotoCom32" Alias "_BscMovl@32" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef vtype As String, spd As Double, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef framename As String, rconf As Short, toolno As Short, ByRef p As Double) As Short

		' Token: 0x060003CF RID: 975
		Public Declare Ansi Function BscMovlEx Lib "MotoCom32" Alias "_BscMovlEx@36" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef vtype As String, spd As Double, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef framename As String, rconf As Integer, toolno As Short, ByRef p As Double, axisNum As Short) As Short

		' Token: 0x060003D0 RID: 976
		Public Declare Ansi Function BscOpen Lib "MotoCom32" Alias "_BscOpen@8" (<MarshalAs(UnmanagedType.VBByRefStr)> ByRef path As String, mode As Short) As Short

		' Token: 0x060003D1 RID: 977
		Public Declare Ansi Function BscOPLock Lib "MotoCom32" Alias "_BscOPLock@4" (nCid As Short) As Short

		' Token: 0x060003D2 RID: 978
		Public Declare Ansi Function BscOPUnLock Lib "MotoCom32" Alias "_BscOPUnLock@4" (nCid As Short) As Short

		' Token: 0x060003D3 RID: 979
		Public Declare Ansi Function BscOutBytes Lib "MotoCom32" Alias "_BscOutBytes@4" (nCid As Short) As Short

		' Token: 0x060003D4 RID: 980
		Public Declare Ansi Function BscPMov Lib "MotoCom32" Alias "_BscPMov@28" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef movtype As String, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef vtype As String, spd As Double, toolno As Short, ByRef p As Double) As Short

		' Token: 0x060003D5 RID: 981
		Public Declare Ansi Function BscPMovEx Lib "MotoCom32" Alias "_BscPMovEx@32" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef movtype As String, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef vtype As String, spd As Double, toolno As Short, ByRef p As Double, axisNum As Short) As Short

		' Token: 0x060003D6 RID: 982
		Public Declare Ansi Function BscPMovj Lib "MotoCom32" Alias "_BscPMovj@20" (nCid As Short, spd As Double, toolno As Short, ByRef p As Double) As Short

		' Token: 0x060003D7 RID: 983
		Public Declare Ansi Function BscPMovjEx Lib "MotoCom32" Alias "_BscPMovjEx@24" (nCid As Short, spd As Double, toolno As Short, ByRef p As Double, axisNum As Short) As Short

		' Token: 0x060003D8 RID: 984
		Public Declare Ansi Function BscPMovl Lib "MotoCom32" Alias "_BscPMovl@24" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef vtype As String, spd As Double, toolno As Short, ByRef p As Double) As Short

		' Token: 0x060003D9 RID: 985
		Public Declare Ansi Function BscPMovlEx Lib "MotoCom32" Alias "_BscPMovlEx@28" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef vtype As String, spd As Double, toolno As Short, ByRef p As Double, axisNum As Short) As Short

		' Token: 0x060003DA RID: 986
		Public Declare Ansi Function BscPuts Lib "MotoCom32" Alias "_BscPuts@12" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef bufptr As String, length As Short) As Short

		' Token: 0x060003DB RID: 987
		Public Declare Ansi Function BscPutUFrame Lib "MotoCom32" Alias "_BscPutUFrame@12" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef ufname As String, ByRef p As Double) As Short

		' Token: 0x060003DC RID: 988
		Public Declare Ansi Function BscPutVarData Lib "MotoCom32" Alias "_BscPutVarData@16" (nCid As Short, type_v As Short, varno As Short, ByRef dat As Double) As Short

		' Token: 0x060003DD RID: 989
		Public Declare Ansi Function BscPutVarData2 Lib "MotoCom32" Alias "_BscPutVarData2@20" (nCid As Short, type_v As Short, varno As Short, ByRef dat As Double, axisNum As Short) As Short

		' Token: 0x060003DE RID: 990
		Public Declare Ansi Function BscPutVarDataEx Lib "MotoCom32" Alias "_BscPutVarDataEx@24" (nCid As Short, type_v As Short, varno As Short, ByRef dat As Double, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef s As String, axisNum As Short) As Short

		' Token: 0x060003DF RID: 991
		Public Declare Ansi Function BscReadAlarmS Lib "MotoCom32" Alias "_BscReadAlarmS@12" (nCid As Short, ByRef data_v As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef s As String) As Short

		' Token: 0x060003E0 RID: 992
		Public Declare Ansi Function BscReadIO Lib "MotoCom32" Alias "_BscReadIO@16" (nCid As Short, startadd As Short, ionum As Short, ByRef stat As Short) As Short

		' Token: 0x060003E1 RID: 993
		Public Declare Ansi Function BscReadIO2 Lib "MotoCom32" Alias "_BscReadIO2@16" (nCid As Short, startadd As Integer, ionum As Short, ByRef stat As Short) As Short

		' Token: 0x060003E2 RID: 994
		Public Declare Ansi Function BscReConnect Lib "MotoCom32" Alias "_BscReConnect@4" (nCid As Short) As Short

		' Token: 0x060003E3 RID: 995
		Public Declare Ansi Function BscReset Lib "MotoCom32" Alias "_BscReset@4" (nCid As Short) As Short

		' Token: 0x060003E4 RID: 996
		Public Declare Ansi Function BscReStartJob Lib "MotoCom32" Alias "_BscReStartJob@4" (nCid As Short) As Short

		' Token: 0x060003E5 RID: 997
		Public Declare Ansi Function BscSelectJob Lib "MotoCom32" Alias "_BscSelectJob@8" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef name_v As String) As Short

		' Token: 0x060003E6 RID: 998
		Public Declare Ansi Function BscSelectMode Lib "MotoCom32" Alias "_BscSelectMode@8" (nCid As Short, mode As Short) As Short

		' Token: 0x060003E7 RID: 999
		Public Declare Ansi Function BscSelLoopCycle Lib "MotoCom32" Alias "_BscSelLoopCycle@4" (nCid As Short) As Short

		' Token: 0x060003E8 RID: 1000
		Public Declare Ansi Function BscSelOneCycle Lib "MotoCom32" Alias "_BscSelOneCycle@4" (nCid As Short) As Short

		' Token: 0x060003E9 RID: 1001
		Public Declare Ansi Function BscSelStepCycle Lib "MotoCom32" Alias "_BscSelStepCycle@4" (nCid As Short) As Short

		' Token: 0x060003EA RID: 1002
		Public Declare Ansi Function BscServoOff Lib "MotoCom32" Alias "_BscServoOff@4" (nCid As Short) As Short

		' Token: 0x060003EB RID: 1003
		Public Declare Ansi Function BscServoOn Lib "MotoCom32" Alias "_BscServoOn@4" (nCid As Short) As Short

		' Token: 0x060003EC RID: 1004
		Public Declare Ansi Function BscSetBreak Lib "MotoCom32" Alias "_BscSetBreak@8" (nCid As Short, flg As Short) As Short

		' Token: 0x060003ED RID: 1005
		Public Declare Ansi Function BscSetCom Lib "MotoCom32" Alias "_BscSetCom@24" (nCid As Short, port As Short, baud As Integer, parity As Short, clen As Short, stp As Short) As Short

		' Token: 0x060003EE RID: 1006
		Public Declare Ansi Function BscSetCondBSC Lib "MotoCom32" Alias "_BscSetCondBSC@20" (nCid As Short, timerA As Short, timerB As Short, rtyR As Short, rtyW As Short) As Short

		' Token: 0x060003EF RID: 1007
		Public Declare Ansi Function BscSetCtrlGroup Lib "MotoCom32" Alias "_BscSetCtrlGroup@8" (nCid As Short, groupno As Short) As Short

		' Token: 0x060003F0 RID: 1008
		Public Declare Ansi Function BscSetCtrlGroupDx Lib "MotoCom32" Alias "_BscSetCtrlGroupDx@12" (nCid As Short, groupno1 As Integer, groupno2 As Integer) As Short

		' Token: 0x060003F1 RID: 1009
		Public Declare Ansi Function BscSetCtrlGroupXrc Lib "MotoCom32" Alias "_BscSetCtrlGroupXrc@12" (nCid As Short, groupno1 As Short, groupno2 As Short) As Short

		' Token: 0x060003F2 RID: 1010
		Public Declare Ansi Function BscSetEServer Lib "MotoCom32" Alias "_BscSetEServer@8" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef IPaddr As String) As Short

		' Token: 0x060003F3 RID: 1011
		Public Declare Ansi Function BscSetEServerMode Lib "MotoCom32" Alias "_BscSetEServerMode@12" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef IPaddr As String, mode As Short) As Short

		' Token: 0x060003F4 RID: 1012
		Public Declare Ansi Function BscSetEther Lib "MotoCom32" Alias "_BscSetEther@16" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef IPaddr As String, mode As Short, hWnd As Integer) As Short

		' Token: 0x060003F5 RID: 1013
		Public Declare Ansi Function BscSetLineNumber Lib "MotoCom32" Alias "_BscSetLineNumber@8" (nCid As Short, line_v As Short) As Short

		' Token: 0x060003F6 RID: 1014
		Public Declare Ansi Function BscSetMasterJob Lib "MotoCom32" Alias "_BscSetMasterJob@4" (nCid As Short) As Short

		' Token: 0x060003F7 RID: 1015
		Public Declare Ansi Function BscStartJob Lib "MotoCom32" Alias "_BscStartJob@4" (nCid As Short) As Short

		' Token: 0x060003F8 RID: 1016
		Public Declare Ansi Function BscStatus Lib "MotoCom32" Alias "_BscStatus@20" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef hpt As String, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef dpt As String, sz As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef rbuf As String) As Short

		' Token: 0x060003F9 RID: 1017
		Public Declare Ansi Function BscUpLoad Lib "MotoCom32" Alias "_BscUpLoad@8" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef fname As String) As Short

		' Token: 0x060003FA RID: 1018
		Public Declare Ansi Function BscUpLoadEx Lib "MotoCom32" Alias "_BscUpLoadEx@16" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef fname As String, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef desPath As String, nFlg As Boolean) As Short

		' Token: 0x060003FB RID: 1019
		Public Declare Ansi Function BscWriteIO Lib "MotoCom32" Alias "_BscWriteIO@16" (nCid As Short, startadd As Short, ionum As Short, ByRef stat As Short) As Short

		' Token: 0x060003FC RID: 1020
		Public Declare Ansi Function BscWriteIO2 Lib "MotoCom32" Alias "_BscWriteIO2@16" (nCid As Short, startadd As Integer, ionum As Short, ByRef stat As Short) As Short

		' Token: 0x060003FD RID: 1021
		Public Declare Ansi Function FcClose Lib "MotoCom32" Alias "_FcClose@4" (nCid As Short) As Short

		' Token: 0x060003FE RID: 1022
		Public Declare Ansi Function FcConnect Lib "MotoCom32" Alias "_FcConnect@4" (nCid As Short) As Short

		' Token: 0x060003FF RID: 1023
		Public Declare Ansi Function FcDisConnect Lib "MotoCom32" Alias "_FcDisConnect@4" (nCid As Short) As Short

		' Token: 0x06000400 RID: 1024
		Public Declare Ansi Function FcGetCom Lib "MotoCom32" Alias "_FcGetCom@12" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef buf As String, size As Short) As Short

		' Token: 0x06000401 RID: 1025
		Public Declare Ansi Function FcGetData Lib "MotoCom32" Alias "_FcGetData@12" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef buf As String, size As Short) As Short

		' Token: 0x06000402 RID: 1026
		Public Declare Ansi Function FcGetPath Lib "MotoCom32" Alias "_FcGetPath@12" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef buf As String, size As Short) As Short

		' Token: 0x06000403 RID: 1027
		Public Declare Ansi Function FcOpen Lib "MotoCom32" Alias "_FcOpen@8" (<MarshalAs(UnmanagedType.VBByRefStr)> ByRef path As String, mode As Short) As Short

		' Token: 0x06000404 RID: 1028
		Public Declare Ansi Function FcProc Lib "MotoCom32" Alias "_FcProc@8" (nCid As Short, isremove As Short) As Short

		' Token: 0x06000405 RID: 1029
		Public Declare Ansi Function FcScan Lib "MotoCom32" Alias "_FcScan@4" (nCid As Short) As Short

		' Token: 0x06000406 RID: 1030
		Public Declare Ansi Function FcSetBreak Lib "MotoCom32" Alias "_FcSetBreak@8" (nCid As Short, flg As Short) As Short

		' Token: 0x06000407 RID: 1031
		Public Declare Ansi Function FcSetCom Lib "MotoCom32" Alias "_FcSetCom@24" (nCid As Short, port As Short, baud As Integer, parity As Short, clen As Short, stp As Short) As Short

		' Token: 0x06000408 RID: 1032
		Public Declare Ansi Function FcSetHSL Lib "MotoCom32" Alias "_FcSetHSL@12" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef strName As String, port As Short) As Short

		' Token: 0x06000409 RID: 1033
		Public Declare Ansi Function FcAutoDeleteSet Lib "MotoCom32" Alias "_FcAutoDeleteSet@8" (nCid As Short, flg As Short) As Short

		' Token: 0x0600040A RID: 1034
		Public Declare Ansi Function FcBye Lib "MotoCom32" Alias "_FcBye@4" (nCid As Short) As Short

		' Token: 0x0600040B RID: 1035
		Public Declare Ansi Function FcChangeDir Lib "MotoCom32" Alias "_FcChangeDir@8" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef dname As String) As Short

		' Token: 0x0600040C RID: 1036
		Public Declare Ansi Function FcChangeDrive Lib "MotoCom32" Alias "_FcChangeDrive@8" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef type_v As String) As Short

		' Token: 0x0600040D RID: 1037
		Public Declare Ansi Function FcDiskSize Lib "MotoCom32" Alias "_FcDiskSize@12" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef disksize As String, size As Short) As Short

		' Token: 0x0600040E RID: 1038
		Public Declare Ansi Function FcDiskSizeSet Lib "MotoCom32" Alias "_FcDiskSizeSet@8" (nCid As Short, flg As Short) As Short

		' Token: 0x0600040F RID: 1039
		Public Declare Ansi Function FcDownload Lib "MotoCom32" Alias "_FcDownload@8" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef fname As String) As Short

		' Token: 0x06000410 RID: 1040
		Public Declare Ansi Function FcFileSize Lib "MotoCom32" Alias "_FcFileSize@12" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef fname As String, ByRef size As Integer) As Short

		' Token: 0x06000411 RID: 1041
		Public Declare Ansi Function FcFindCurrentDir Lib "MotoCom32" Alias "_FcFindCurrentDir@12" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef dname As String, size As Short) As Short

		' Token: 0x06000412 RID: 1042
		Public Declare Ansi Function FcFindFirst Lib "MotoCom32" Alias "_FcFindFirst@12" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef fname As String, size As Short) As Short

		' Token: 0x06000413 RID: 1043
		Public Declare Ansi Function FcFindFirstDir Lib "MotoCom32" Alias "_FcFindFirstDir@12" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef dname As String, size As Short) As Short

		' Token: 0x06000414 RID: 1044
		Public Declare Ansi Function FcFindNext Lib "MotoCom32" Alias "_FcFindNext@12" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef fname As String, size As Short) As Short

		' Token: 0x06000415 RID: 1045
		Public Declare Ansi Function FcFindNextDir Lib "MotoCom32" Alias "_FcFindNextDir@12" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef dname As String, size As Short) As Short

		' Token: 0x06000416 RID: 1046
		Public Declare Ansi Function FcIsDiskSize Lib "MotoCom32" Alias "_FcIsDiskSize@4" (nCid As Short) As Short

		' Token: 0x06000417 RID: 1047
		Public Declare Ansi Function FcLogin Lib "MotoCom32" Alias "_FcLogin@4" (nCid As Short) As Short

		' Token: 0x06000418 RID: 1048
		Public Declare Ansi Function FcLogout Lib "MotoCom32" Alias "_FcLogout@4" (nCid As Short) As Short

		' Token: 0x06000419 RID: 1049
		Public Declare Ansi Function FcMakeDir Lib "MotoCom32" Alias "_FcMakeDir@8" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef dname As String) As Short

		' Token: 0x0600041A RID: 1050
		Public Declare Ansi Function FcRemove Lib "MotoCom32" Alias "_FcRemove@8" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef fname As String) As Short

		' Token: 0x0600041B RID: 1051
		Public Declare Ansi Function FcRename Lib "MotoCom32" Alias "_FcRename@12" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef oldname As String, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef newname As String) As Short

		' Token: 0x0600041C RID: 1052
		Public Declare Ansi Function FcUpload Lib "MotoCom32" Alias "_FcUpload@8" (nCid As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef fname As String) As Short

		' Token: 0x04000154 RID: 340
		Public Const PACKETCOM As Short = 1S

		' Token: 0x04000155 RID: 341
		Public Const PACKETLPT As Short = 2S

		' Token: 0x04000156 RID: 342
		Public Const PACKETHSLSERVER As Short = 3S

		' Token: 0x04000157 RID: 343
		Public Const PACKETHSLCLIENT As Short = 4S

		' Token: 0x04000158 RID: 344
		Public Const PACKETETHERNET As Short = 16S

		' Token: 0x04000159 RID: 345
		Public Const PACKETESERVER As Short = 256S

		' Token: 0x0400015A RID: 346
		Public Const PACKETESERVER_NO_LINGER As Short = 4096S
	End Module
End Namespace
