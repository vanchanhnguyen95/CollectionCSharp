# Catfood.Shapefile
Fork from codeplex source for minor changes and nuget package.

Original repo at https://shapefile.codeplex.com/

## Releases

If you don't want to rebuild anything just pick it up here : https://github.com/Uwy/Catfood.Shapefile/releases

## Instructions

Following instructions expect you're using a cygwin/bash/zsh that works with nuget in path and working in the Catfood.Shapefile project directory (at the root next to csproj file).

### To build and pack :
```bash
$ ./nuget-pack.sh
```

### To add to your local repo :
```
$ nuget add nupkgs/Catfood.Shapefile.X.YZ.nupkg -source /your/local/nuget/repo
```
Where `X.YZ` is the version of the package you want to publish and `/your/local/nuget/repo` the path of your local nuget package repository.

Note : On windows, putting -source path in windows style path like `"C:/My/Good/Old/welpdows/path"` works too.
