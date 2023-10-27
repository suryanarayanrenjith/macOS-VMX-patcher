# macOS VMX Patcher (For VMware)
<img src="/VMware%20Patcher.jpg?raw=true" width="100" align="right">
A tool for automatically patching your macOS VMware virtual machine (.vmx file) for easy install of your macOS operating system. 

## How to Download

My tool is available in the [Releases](https://github.com/suryanarayanrenjith/macOS-VMX-patcher/releases) section, please note that this tool only runs in windows.

## Prerequisites
Since my tool is written in C#, .NET 6.0 Desktop Runtime is required in order to run this tool. You can download it from this 
[link.](https://download.visualstudio.microsoft.com/download/pr/83d32568-c5a2-4117-9591-437051785f41/e75171da01b1fa5c796660dc4b96beed/windowsdesktop-runtime-6.0.23-win-x64.exe ".NET 6.0 Desktop Runtime")
## How to Use
1) Choose your .vmx file from the folder where you installed your virtual machine.
2) Choose your CPU (Intel/AMD).
3) Patch!\
*Please test your virtual machine by keeping VMX Patcher open. If you close the patcher, you will not be able to uninstall the patch.*
## Limitations
- Uninstall does not work when you close the program.
- No releases for Linux operating system.

**Note:-** If you accidentally closed the program and if you wish to uninstall the code, follow these steps.
1) Go to your virtual machine .vmx file location.
2) Right click on the file and select open with notepad.
3) Depending on your CPU (Intel/AMD) remove these lines of code.
### Intel CPU
```
smc.version = "0"
smbios.reflectHost = "TRUE"
hw.model = "MacBookPro14,3"
board-id = "Mac-551B86E5744E2388"
```

### AMD CPU
```
smc.version = "0"
cpuid.0.eax = "0000:0000:0000:0000:0000:0000:0000:1011"
cpuid.0.ebx = "0111:0101:0110:1110:0110:0101:0100:0111"
cpuid.0.ecx = "0110:1100:0110:0101:0111:0100:0110:1110"
cpuid.0.edx = "0100:1001:0110:0101:0110:1110:0110:1001"
cpuid.1.eax = "0000:0000:0000:0001:0000:0110:0111:0001"
cpuid.1.ebx = "0000:0010:0000:0001:0000:1000:0000:0000"
cpuid.1.ecx = "1000:0010:1001:1000:0010:0010:0000:0011"
cpuid.1.edx = "0000:0111:1000:1011:1111:1011:1111:1111"
smbios.reflectHost = "TRUE"
hw.model = "MacBookPro14,3"
board-id = "Mac-551B86E5744E2388"
```

## License

[MIT](https://choosealicense.com/licenses/mit/)
