# Website2App
A simple Windows Application to load a Website as a Desktop Application


Just Create a shortcut to the Executable or put it in the Taskbar. The Executable takes two commandline arguments:
- The URL for the Website. This HAS TO BE a full URL. With http/https
- The Title of the Window (Optional). If not present, your provided URL will be the Title

Example: Website2App.exe https://mail.google.com GMail
  
Currently, you need to set the Icon for the shortcut yourself.

If you need specific scripting or you get errors on loading the website, you need to add the following into the Registry:
HKLM\SOFTWARE\WOW6432Node\Microsoft\Internet Explorer\Main\FeaterControl\FEATURE_BROWSER_EMULATION\
- Create a new DWORD entry
- Name is "Website2App.exe"
- Value is "11001" Decimal

This ensures the App is using IE11 as a Browser engine. If not present, it defaults to some older version which doesn't support some kinds of scripting or other features.
