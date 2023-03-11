# Simple-Software-Protection-Suite .NET 7

## UPDATED TO .NET 7   

[ <span style="color:green">✓</span> ] WINFORMS UTILITY  
[ <span style="color:green">✓</span> ] WINDOWS ONLY LIBRARY   
[ <span style="color:red">X</span> ] LINUX ONLY LIBRARY   
[ <span style="color:red">X</span> ] MACOS ONLY LIBRARY    
[ <span style="color:red">X</span> ] NET STANDARD 2.0 LIBRARY    

Simple attempt to generate a class to create protection keys for software.   
One of my customers want a not so complicated method to try to get a minimum of security for his propietary software.  
This is that project.    
Nothing unbeteable, nothing complicated just a little layer of protection for your software.     

### WINFORMS UTILITY
This form allows you to select CPU_ID, HDD_ID and BIOS_ID and generate base64 string keys wiht SHA256 encryption based on supplied SECRET     
### WINDOWS ONLY LIBRARY

```csharp
var hwInfo = new WindowsHardwareInfo();
hwInfo.CollectData(); // Fills Collections of Hardware Info
hwInfo.Cpus; // List<string> containing cpu_ids
hwInfo.Hdds; // List<string> containing hdd_ids
hwInfo.Bios; // List<string> containing motherboard_bios_ids

var secret = "MY_SUPER_SECRET_KEY";
var keyGenerator = new WindowsKeyGenerator(secret,hwInfo.Cpus.First(),hwInfo.Hdds.First(),hwInfo.Bios.First());
var generatedKey = keyGenerator.ReturnKey();  //base64 string with SHA256 encryptedkey based on present hardware
```





There are plenty of paid protection suites a lot more robust and strong.  
As an free software and fully Opensource beleiver I made the library available to anyone that needs this little tool.


//Reference for Implementation https://github.com/Jinjinov/Hardware.Info
