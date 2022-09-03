using System.IO;
using Kogane.Internal;

public static class Directory
{
    public static DirectoryInfo CreateDirectory( string path ) => System.IO.Directory.CreateDirectory( path );

    public static void Delete( string path )                 => System.IO.Directory.Delete( path );
    public static void Delete( string path, bool recursive ) => System.IO.Directory.Delete( path, recursive );

    public static System.Collections.Generic.IEnumerable<string> EnumerateDirectories( string path )                                                              => System.IO.Directory.EnumerateDirectories( path ).Fix();
    public static System.Collections.Generic.IEnumerable<string> EnumerateDirectories( string path, string searchPattern )                                        => System.IO.Directory.EnumerateDirectories( path, searchPattern ).Fix();
    public static System.Collections.Generic.IEnumerable<string> EnumerateDirectories( string path, string searchPattern, EnumerationOptions enumerationOptions ) => System.IO.Directory.EnumerateDirectories( path, searchPattern, enumerationOptions ).Fix();
    public static System.Collections.Generic.IEnumerable<string> EnumerateDirectories( string path, string searchPattern, SearchOption       searchOption )       => System.IO.Directory.EnumerateDirectories( path, searchPattern, searchOption ).Fix();

    public static System.Collections.Generic.IEnumerable<string> EnumerateFiles( string path )                                                              => System.IO.Directory.EnumerateFiles( path ).Fix();
    public static System.Collections.Generic.IEnumerable<string> EnumerateFiles( string path, string searchPattern )                                        => System.IO.Directory.EnumerateFiles( path, searchPattern ).Fix();
    public static System.Collections.Generic.IEnumerable<string> EnumerateFiles( string path, string searchPattern, EnumerationOptions enumerationOptions ) => System.IO.Directory.EnumerateFiles( path, searchPattern, enumerationOptions ).Fix();
    public static System.Collections.Generic.IEnumerable<string> EnumerateFiles( string path, string searchPattern, SearchOption       searchOption )       => System.IO.Directory.EnumerateFiles( path, searchPattern, searchOption ).Fix();

    public static System.Collections.Generic.IEnumerable<string> EnumerateFileSystemEntries( string path )                                                              => System.IO.Directory.EnumerateFileSystemEntries( path ).Fix();
    public static System.Collections.Generic.IEnumerable<string> EnumerateFileSystemEntries( string path, string searchPattern )                                        => System.IO.Directory.EnumerateFileSystemEntries( path, searchPattern ).Fix();
    public static System.Collections.Generic.IEnumerable<string> EnumerateFileSystemEntries( string path, string searchPattern, EnumerationOptions enumerationOptions ) => System.IO.Directory.EnumerateFileSystemEntries( path, searchPattern, enumerationOptions ).Fix();
    public static System.Collections.Generic.IEnumerable<string> EnumerateFileSystemEntries( string path, string searchPattern, SearchOption       searchOption )       => System.IO.Directory.EnumerateFileSystemEntries( path, searchPattern, searchOption ).Fix();

    public static bool Exists( string path ) => System.IO.Directory.Exists( path );

    public static System.DateTime GetCreationTime( string    path ) => System.IO.Directory.GetCreationTime( path );
    public static System.DateTime GetCreationTimeUtc( string path ) => System.IO.Directory.GetCreationTimeUtc( path );

    public static string GetCurrentDirectory() => System.IO.Directory.GetCurrentDirectory().Fix();

    public static string[] GetDirectories( string path )                                                              => System.IO.Directory.GetDirectories( path ).Fix();
    public static string[] GetDirectories( string path, string searchPattern )                                        => System.IO.Directory.GetDirectories( path, searchPattern ).Fix();
    public static string[] GetDirectories( string path, string searchPattern, EnumerationOptions enumerationOptions ) => System.IO.Directory.GetDirectories( path, searchPattern, enumerationOptions ).Fix();
    public static string[] GetDirectories( string path, string searchPattern, SearchOption       searchOption )       => System.IO.Directory.GetDirectories( path, searchPattern, searchOption ).Fix();

    public static string GetDirectoryRoot( string path ) => System.IO.Directory.GetDirectoryRoot( path ).Fix();

    public static string[] GetFiles( string path )                                                              => System.IO.Directory.GetFiles( path ).Fix();
    public static string[] GetFiles( string path, string searchPattern )                                        => System.IO.Directory.GetFiles( path, searchPattern ).Fix();
    public static string[] GetFiles( string path, string searchPattern, EnumerationOptions enumerationOptions ) => System.IO.Directory.GetFiles( path, searchPattern, enumerationOptions ).Fix();
    public static string[] GetFiles( string path, string searchPattern, SearchOption       searchOption )       => System.IO.Directory.GetFiles( path, searchPattern, searchOption ).Fix();

    public static string[] GetFileSystemEntries( string path )                                                              => System.IO.Directory.GetFileSystemEntries( path ).Fix();
    public static string[] GetFileSystemEntries( string path, string searchPattern )                                        => System.IO.Directory.GetFileSystemEntries( path, searchPattern ).Fix();
    public static string[] GetFileSystemEntries( string path, string searchPattern, EnumerationOptions enumerationOptions ) => System.IO.Directory.GetFileSystemEntries( path, searchPattern, enumerationOptions ).Fix();
    public static string[] GetFileSystemEntries( string path, string searchPattern, SearchOption       searchOption )       => System.IO.Directory.GetFileSystemEntries( path, searchPattern, searchOption ).Fix();

    public static System.DateTime GetLastAccessTime( string    path ) => System.IO.Directory.GetLastAccessTime( path );
    public static System.DateTime GetLastAccessTimeUtc( string path ) => System.IO.Directory.GetLastAccessTimeUtc( path );
    public static System.DateTime GetLastWriteTime( string     path ) => System.IO.Directory.GetLastWriteTime( path );
    public static System.DateTime GetLastWriteTimeUtc( string  path ) => System.IO.Directory.GetLastWriteTimeUtc( path );

    public static string[] GetLogicalDrives() => System.IO.Directory.GetLogicalDrives().Fix();

    public static DirectoryInfo GetParent( string path ) => System.IO.Directory.GetParent( path );

    public static void Move( string sourceDirName, string destDirName ) => System.IO.Directory.Move( sourceDirName, destDirName );

    public static void SetCreationTime( string      path, System.DateTime creationTime )    => System.IO.Directory.SetCreationTime( path, creationTime );
    public static void SetCreationTimeUtc( string   path, System.DateTime creationTimeUtc ) => System.IO.Directory.SetCreationTimeUtc( path, creationTimeUtc );
    public static void SetCurrentDirectory( string  path )                                    => System.IO.Directory.SetCurrentDirectory( path );
    public static void SetLastAccessTime( string    path, System.DateTime lastAccessTime )    => System.IO.Directory.SetLastAccessTime( path, lastAccessTime );
    public static void SetLastAccessTimeUtc( string path, System.DateTime lastAccessTimeUtc ) => System.IO.Directory.SetLastAccessTimeUtc( path, lastAccessTimeUtc );
    public static void SetLastWriteTime( string     path, System.DateTime lastWriteTime )     => System.IO.Directory.SetLastWriteTime( path, lastWriteTime );
    public static void SetLastWriteTimeUtc( string  path, System.DateTime lastWriteTimeUtc )  => System.IO.Directory.SetLastWriteTimeUtc( path, lastWriteTimeUtc );
}