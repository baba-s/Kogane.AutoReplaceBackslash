# Kogane Auto Replace Backslash

System.IO.Path や System.IO.Directory で取得できるパスのバックスラッシュを自動でスラッシュに変換するパッケージ

## 使用例

### Before

```csharp
using System.IO;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void Start()
    {
        var path = @"C:\Program Files\Unity Hub\Unity Hub.exe";

        Debug.Log( Path.ChangeExtension( path, ".bat" ) );              // C:\Program Files\Unity Hub\Unity Hub.bat
        Debug.Log( Path.Combine( "a" ) );                               // a
        Debug.Log( Path.Combine( "a", "b" ) );                          // a\b
        Debug.Log( Path.Combine( "a", "b", "c" ) );                     // a\b\c
        Debug.Log( Path.Combine( "a", "b", "c", "d" ) );                // a\b\c\d
        Debug.Log( Path.Combine( "a", "b", "c", "d", "e" ) );           // a\b\c\d\e
        Debug.Log( Path.GetDirectoryName( path ) );                     // C:\Program Files\Unity Hub
        Debug.Log( Path.GetExtension( path ) );                         // .exe
        Debug.Log( Path.GetFileName( path ) );                          // Unity Hub.exe
        Debug.Log( Path.GetFileNameWithoutExtension( path ) );          // Unity Hub
        Debug.Log( Path.GetFullPath( path ) );                          // C:\Program Files\Unity Hub\Unity Hub.exe
        Debug.Log( Path.GetFullPath( path, @"C:\Program Files" ) );     // C:\Program Files\Unity Hub\Unity Hub.exe
        Debug.Log( Path.GetPathRoot( path ) );                          // C:\
        Debug.Log( Path.GetRelativePath( path, @"C:\Program Files" ) ); // ..\..
        Debug.Log( Path.GetTempFileName() );                            // C:\Users\【ユーザー名】\AppData\Local\Temp\XXXX.tmp
        Debug.Log( Path.GetTempPath() );                                // C:\Users\【ユーザー名】\AppData\Local\Temp\

        path = @"C:\Program Files\Unity Hub";

        // C:\Program Files\Unity Hub\Frameworks
        // C:\Program Files\Unity Hub\locales
        // ...
        Debug.Log( string.Join( "\n", Directory.EnumerateDirectories( path ) ) );

        // C:\Program Files\Unity Hub\chrome_100_percent.pak
        // C:\Program Files\Unity Hub\chrome_200_percent.pak
        // ...
        Debug.Log( string.Join( "\n", Directory.EnumerateFiles( path ) ) );

        // C:\Program Files\Unity Hub\chrome_100_percent.pak
        // C:\Program Files\Unity Hub\chrome_200_percent.pak
        // ...
        Debug.Log( string.Join( "\n", Directory.EnumerateFileSystemEntries( path ) ) );

        // C:\Users\【ユーザー名】\UnityProject
        Debug.Log( Directory.GetCurrentDirectory() );

        // C:\Program Files\Unity Hub\Frameworks
        // C:\Program Files\Unity Hub\locales
        // ...
        Debug.Log( string.Join( "\n", Directory.GetDirectories( path ) ) );

        // C:\
        Debug.Log( Directory.GetDirectoryRoot( path ) );

        // C:\Program Files\Unity Hub\chrome_100_percent.pak
        // C:\Program Files\Unity Hub\chrome_200_percent.pak
        // ...
        Debug.Log( string.Join( "\n", Directory.GetFiles( path ) ) );

        // C:\Program Files\Unity Hub\chrome_100_percent.pak
        // C:\Program Files\Unity Hub\chrome_200_percent.pak
        // ...
        Debug.Log( string.Join( "\n", Directory.GetFileSystemEntries( path ) ) );

        // C:\
        // D:\
        Debug.Log( string.Join( "\n", Directory.GetLogicalDrives() ) );
    }
}
```

### After

```csharp
using System.IO;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void Start()
    {
        var path = @"C:\Program Files\Unity Hub\Unity Hub.exe";

        Debug.Log( Path.ChangeExtension( path, ".bat" ) );              // C:/Program Files/Unity Hub/Unity Hub.bat
        Debug.Log( Path.Combine( "a" ) );                               // a
        Debug.Log( Path.Combine( "a", "b" ) );                          // a/b
        Debug.Log( Path.Combine( "a", "b", "c" ) );                     // a/b/c
        Debug.Log( Path.Combine( "a", "b", "c", "d" ) );                // a/b/c/d
        Debug.Log( Path.Combine( "a", "b", "c", "d", "e" ) );           // a/b/c/d/e
        Debug.Log( Path.GetDirectoryName( path ) );                     // C:/Program Files/Unity Hub
        Debug.Log( Path.GetExtension( path ) );                         // .exe
        Debug.Log( Path.GetFileName( path ) );                          // Unity Hub.exe
        Debug.Log( Path.GetFileNameWithoutExtension( path ) );          // Unity Hub
        Debug.Log( Path.GetFullPath( path ) );                          // C:/Program Files/Unity Hub/Unity Hub.exe
        Debug.Log( Path.GetFullPath( path, @"C:\Program Files" ) );     // C:/Program Files/Unity Hub/Unity Hub.exe
        Debug.Log( Path.GetPathRoot( path ) );                          // C:/
        Debug.Log( Path.GetRelativePath( path, @"C:\Program Files" ) ); // ../..
        Debug.Log( Path.GetTempFileName() );                            // C:/Users/【ユーザー名】/AppData/Local/Temp/XXXX.tmp
        Debug.Log( Path.GetTempPath() );                                // C:/Users/【ユーザー名】/AppData/Local/Temp/

        path = @"C:\Program Files\Unity Hub";

        // C:/Program Files/Unity Hub/Frameworks
        // C:/Program Files/Unity Hub/locales
        // ...
        Debug.Log( string.Join( "\n", Directory.EnumerateDirectories( path ) ) );

        // C:/Program Files/Unity Hub/chrome_100_percent.pak
        // C:/Program Files/Unity Hub/chrome_200_percent.pak
        // ...
        Debug.Log( string.Join( "\n", Directory.EnumerateFiles( path ) ) );

        // C:/Program Files/Unity Hub/chrome_100_percent.pak
        // C:/Program Files/Unity Hub/chrome_200_percent.pak
        // ...
        Debug.Log( string.Join( "\n", Directory.EnumerateFileSystemEntries( path ) ) );

        // C:/Users/【ユーザー名】/UnityProject
        Debug.Log( Directory.GetCurrentDirectory() );

        // C:/Program Files/Unity Hub/Frameworks
        // C:/Program Files/Unity Hub/locales
        // ...
        Debug.Log( string.Join( "\n", Directory.GetDirectories( path ) ) );

        // C:/
        Debug.Log( Directory.GetDirectoryRoot( path ) );

        // C:/Program Files/Unity Hub/chrome_100_percent.pak
        // C:/Program Files/Unity Hub/chrome_200_percent.pak
        // ...
        Debug.Log( string.Join( "\n", Directory.GetFiles( path ) ) );

        // C:/Program Files/Unity Hub/chrome_100_percent.pak
        // C:/Program Files/Unity Hub/chrome_200_percent.pak
        // ...
        Debug.Log( string.Join( "\n", Directory.GetFileSystemEntries( path ) ) );

        // C:/
        // D:/
        Debug.Log( string.Join( "\n", Directory.GetLogicalDrives() ) );
    }
}
```