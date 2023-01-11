using System;
using Kogane.Internal;

public static class Path
{
    public static char AltDirectorySeparatorChar => System.IO.Path.AltDirectorySeparatorChar;
    public static char DirectorySeparatorChar    => System.IO.Path.DirectorySeparatorChar;

    [Obsolete( "Please use GetInvalidPathChars or GetInvalidFileNameChars instead." )]
    public static char[] InvalidPathChars => System.IO.Path.InvalidPathChars;

    public static char PathSeparator       => System.IO.Path.PathSeparator;
    public static char VolumeSeparatorChar => System.IO.Path.VolumeSeparatorChar;

    public static string ChangeExtension( string path, string extension ) => System.IO.Path.ChangeExtension( path, extension ).Fix();

    public static string Combine( string          path1, string path2 )                             => System.IO.Path.Combine( path1, path2 ).Fix();
    public static string Combine( string          path1, string path2, string path3 )               => System.IO.Path.Combine( path1, path2, path3 ).Fix();
    public static string Combine( string          path1, string path2, string path3, string path4 ) => System.IO.Path.Combine( path1, path2, path3, path4 ).Fix();
    public static string Combine( params string[] paths ) => System.IO.Path.Combine( paths ).Fix();

    public static ReadOnlySpan<char> GetDirectoryName( ReadOnlySpan<char> path ) => System.IO.Path.GetDirectoryName( path );
    public static string             GetDirectoryName( string             path ) => System.IO.Path.GetDirectoryName( path ).Fix();

    public static ReadOnlySpan<char> GetExtension( ReadOnlySpan<char> path ) => System.IO.Path.GetExtension( path );
    public static string             GetExtension( string             path ) => System.IO.Path.GetExtension( path ).Fix();

    public static ReadOnlySpan<char> GetFileName( ReadOnlySpan<char> path ) => System.IO.Path.GetFileName( path );
    public static string             GetFileName( string             path ) => System.IO.Path.GetFileName( path ).Fix();

    public static ReadOnlySpan<char> GetFileNameWithoutExtension( ReadOnlySpan<char> path ) => System.IO.Path.GetFileNameWithoutExtension( path );
    public static string             GetFileNameWithoutExtension( string             path ) => System.IO.Path.GetFileNameWithoutExtension( path ).Fix();

    public static string GetFullPath( string path )                  => System.IO.Path.GetFullPath( path ).Fix();
    public static string GetFullPath( string path, string basePath ) => System.IO.Path.GetFullPath( path, basePath ).Fix();

    public static char[] GetInvalidFileNameChars() => System.IO.Path.GetInvalidFileNameChars();

    public static char[] GetInvalidPathChars() => System.IO.Path.GetInvalidPathChars();

    public static ReadOnlySpan<char> GetPathRoot( ReadOnlySpan<char> path ) => System.IO.Path.GetPathRoot( path );
    public static string             GetPathRoot( string             path ) => System.IO.Path.GetPathRoot( path ).Fix();

    public static string GetRandomFileName() => System.IO.Path.GetRandomFileName().Fix();

    public static string GetRelativePath( string relativeTo, string path ) => System.IO.Path.GetRelativePath( relativeTo, path ).Fix();

    public static string GetTempFileName() => System.IO.Path.GetTempFileName().Fix();

    public static string GetTempPath() => System.IO.Path.GetTempPath().Fix();

    public static bool HasExtension( ReadOnlySpan<char> path ) => System.IO.Path.HasExtension( path );
    public static bool HasExtension( string             path ) => System.IO.Path.HasExtension( path );

    public static bool IsPathFullyQualified( ReadOnlySpan<char> path ) => System.IO.Path.IsPathFullyQualified( path );
    public static bool IsPathFullyQualified( string             path ) => System.IO.Path.IsPathFullyQualified( path );

    public static bool IsPathRooted( ReadOnlySpan<char> path ) => System.IO.Path.IsPathRooted( path );
    public static bool IsPathRooted( string             path ) => System.IO.Path.IsPathRooted( path );

    public static string Join( ReadOnlySpan<char> path1, ReadOnlySpan<char> path2 )                           => System.IO.Path.Join( path1, path2 ).Fix();
    public static string Join( ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, ReadOnlySpan<char> path3 ) => System.IO.Path.Join( path1, path2, path3 ).Fix();

    public static bool TryJoin
    (
        ReadOnlySpan<char> path1,
        ReadOnlySpan<char> path2,
        ReadOnlySpan<char> path3,
        Span<char>         destination,
        out int            charsWritten
    )
    {
        return System.IO.Path.TryJoin
        (
            path1,
            path2,
            path3,
            destination,
            out charsWritten
        );
    }

    public static bool TryJoin
    (
        ReadOnlySpan<char> path1,
        ReadOnlySpan<char> path2,
        Span<char>         destination,
        out int            charsWritten
    )
    {
        return System.IO.Path.TryJoin( path1, path2, destination, out charsWritten );
    }
}