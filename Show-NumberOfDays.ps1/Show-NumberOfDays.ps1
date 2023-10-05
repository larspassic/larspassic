#Show-NumberOfDays.ps1
#Popup the number of days since a specific date.

#Store the start dates as variables
$dateDecember = Get-Date 12/6/2022
$dateFebruary = Get-Date 02/08/2023

#Store today's date as a variable
$today = Get-Date

#Subtract the start date from today's date to compute and output the number of days passed
$daysDecember = ($today - $dateDecember).Days
$daysFebruary = ($today - $dateFebruary).Days

#Create the shell object
$wshell = New-Object -ComObject Wscript.Shell

#Pop up the shell object to the user
$wshell.Popup("It has been $daysDecember days since REDACTED.`n`nIt has been $daysFebruary days since REDACTED.",0,"Number of days",0x1)
