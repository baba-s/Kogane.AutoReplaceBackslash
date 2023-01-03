using Kogane.Internal;
using NUnit.Framework;

namespace Kogane.Test
{
    internal sealed class PathTest
    {
        [Test]
        public void Run()
        {
            var path = @"C:\Program Files\Unity Hub\Unity Hub.exe";

            Assert.AreEqual( Path.AltDirectorySeparatorChar, System.IO.Path.AltDirectorySeparatorChar );
            Assert.AreEqual( Path.DirectorySeparatorChar, System.IO.Path.DirectorySeparatorChar );
            // Assert.AreEqual( Path.InvalidPathChars, System.IO.Path.InvalidPathChars );
            Assert.AreEqual( Path.PathSeparator, System.IO.Path.PathSeparator );
            Assert.AreEqual( Path.VolumeSeparatorChar, System.IO.Path.VolumeSeparatorChar );

            Assert.AreEqual( Path.ChangeExtension( path, ".bat" ), System.IO.Path.ChangeExtension( path, ".bat" ).Fix() );
            Assert.AreEqual( Path.Combine( "a", "b" ), System.IO.Path.Combine( "a", "b" ).Fix() );
            Assert.AreEqual( Path.Combine( "a", "b", "c" ), System.IO.Path.Combine( "a", "b", "c" ).Fix() );
            Assert.AreEqual( Path.Combine( "a", "b", "c", "d" ), System.IO.Path.Combine( "a", "b", "c", "d" ).Fix() );

            Assert.AreEqual
            (
                Path.Combine
                (
                    "a",
                    "b",
                    "c",
                    "d",
                    "e"
                ),
                System.IO.Path.Combine
                    (
                        "a",
                        "b",
                        "c",
                        "d",
                        "e"
                    )
                    .Fix()
            );

            Assert.AreEqual( Path.GetDirectoryName( path ), System.IO.Path.GetDirectoryName( path ).Fix() );
            Assert.AreEqual( Path.GetExtension( path ), System.IO.Path.GetExtension( path ).Fix() );
            Assert.AreEqual( Path.GetFileName( path ), System.IO.Path.GetFileName( path ).Fix() );
            Assert.AreEqual( Path.GetFileNameWithoutExtension( path ), System.IO.Path.GetFileNameWithoutExtension( path ).Fix() );
            Assert.AreEqual( Path.GetFullPath( path ), System.IO.Path.GetFullPath( path ).Fix() );
            Assert.AreEqual( Path.GetFullPath( path, @"C:\Program Files" ), System.IO.Path.GetFullPath( path, @"C:\Program Files" ).Fix() );
            Assert.AreEqual( Path.GetInvalidFileNameChars(), System.IO.Path.GetInvalidFileNameChars() );
            Assert.AreEqual( Path.GetInvalidPathChars(), System.IO.Path.GetInvalidPathChars() );
            Assert.AreEqual( Path.GetPathRoot( path ), System.IO.Path.GetPathRoot( path ).Fix() );
            Assert.AreEqual( Path.GetRelativePath( path, @"C:\Program Files" ), System.IO.Path.GetRelativePath( path, @"C:\Program Files" ).Fix() );
            Assert.AreEqual( Path.HasExtension( path ), System.IO.Path.HasExtension( path ) );
            Assert.AreEqual( Path.IsPathFullyQualified( path ), System.IO.Path.IsPathFullyQualified( path ) );
            Assert.AreEqual( Path.IsPathRooted( path ), System.IO.Path.IsPathRooted( path ) );
        }
    }
}