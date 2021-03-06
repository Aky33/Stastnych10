; Script generated by the Inno Script Studio Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "��astn�ch 10"
#define MyAppVersion "1.0"
#define MyAppPublisher "Aky33"
#define MyAppExeName "S10.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{C8D8DBC8-72CB-4AB4-BC50-5E3CF7DE23C3}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
DefaultDirName={pf}\{#MyAppName}
DefaultGroupName=Stastnych10
AllowNoIcons=yes
OutputBaseFilename=Stastnych10Install
SetupIconFile=S10\stastnych10.ico
Compression=lzma
SolidCompression=yes

[Languages]
Name: "czech"; MessagesFile: "compiler:Languages\Czech.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "S10\bin\Release\S10.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "S10\bin\Release\DryIoc.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "S10\bin\Release\DryIoc.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "S10\bin\Release\EntityFramework.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "S10\bin\Release\EntityFramework.SqlServer.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "S10\bin\Release\EntityFramework.SqlServer.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "S10\bin\Release\EntityFramework.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "S10\bin\Release\S10.CompositionRoot.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "S10\bin\Release\S10.CompositionRoot.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "S10\bin\Release\S10.DataAccessLayer.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "S10\bin\Release\S10.DataAccessLayer.dll.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "S10\bin\Release\S10.DataAccessLayer.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "S10\bin\Release\S10.DomainModel.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "S10\bin\Release\S10.DomainModel.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "S10\bin\Release\S10.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "S10\bin\Release\S10.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "S10\bin\Release\S10.ServiceLayer.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "S10\bin\Release\S10.ServiceLayer.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "S10\bin\Release\System.Data.SQLite.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "S10\bin\Release\System.Data.SQLite.dll.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "S10\bin\Release\System.Data.SQLite.EF6.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "S10\bin\Release\System.Data.SQLite.Linq.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "S10\bin\Release\System.Data.SQLite.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "S10\bin\Release\x64\SQLite.Interop.dll"; DestDir: "{app}/x64"; Flags: ignoreversion
Source: "S10\bin\Release\x86\SQLite.Interop.dll"; DestDir: "{app}/x86"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

[Dirs]
Name: "{app}\x64"
Name: "{app}\x86"

[UninstallDelete]
Type: files; Name: "{app}\database.db"
