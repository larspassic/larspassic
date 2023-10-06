#Show-NumberOfDays.ps1
#Popup the number of days since a specific date

#Store the start dates as variables
$dateDecember = Get-Date 12/6/2022 
$dateFebruary = Get-Date 02/08/2023
$dateToday = Get-Date

#Format the display dates
#Do this by splitting the string on the space character, then keeping the first 4 substrings of the result
$dateTodayDisplay = $dateToday.DateTime.Split(" ")[,0+1+2+3]
$dateDecemberDisplay = $dateDecember.DateTime.Split(" ")[,0+1+2+3]
$dateFebruaryDisplay = $dateFebruary.DateTime.Split(" ")[,0+1+2+3]


#Subtract the start date from today's date to compute and output the number of days passed
$daysDecember = ($dateToday - $dateDecember).Days
$daysFebruary = ($dateToday - $dateFebruary).Days

#Create the shell object
$wshell = New-Object -ComObject Wscript.Shell

#Create the string object that will be used in the body of the popup message
$strText = @"
Today is $dateTodayDisplay.

It has been $daysDecember days since $($dateDecemberDisplay).

It has been $daysFebruary days since $($dateFebruaryDisplay).
"@

#Pop up the shell object to the user
$wshell.Popup($strText,0,"Show-NumberOfDays.ps1",0x0 + 0x40)
