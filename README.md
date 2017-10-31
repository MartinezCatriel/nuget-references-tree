# Nuget References Tree

## Introduction

This utility has as goal to show, in a hierchical way, the dependencies from a local repository.
It navigates into the dependencies recursively until the max depth you provided as a parameter.

## Usage

**The first prompted parameter is the folder needed to search the packages**
```
Enter the local repo folder: C:\Projects\foo\packages
```

**The next parameter is the search criteria just to not search within the whole repo packages**
```
Enter the dependency id matching criteria: System
```

**The last parameter is the max depth to deep into the package dependencies**
```
Enter the maximum depth for the dependency tree: 2
```

## Results
```
System.Collections.Concurrent v4.0.12
   System.Collections v4.3.0
      Microsoft.NETCore.Platforms v1.1.0
      System.Runtime v4.3.0
      Microsoft.NETCore.Platforms v1.1.0
      System.Runtime v4.3.0
      Microsoft.NETCore.Platforms v1.1.0
      System.Runtime v4.3.0
   System.Diagnostics.Debug v4.3.0
      Microsoft.NETCore.Platforms v1.1.0
      System.Runtime v4.3.0
      Microsoft.NETCore.Platforms v1.1.0
      System.Runtime v4.3.0
      Microsoft.NETCore.Platforms v1.1.0
      System.Runtime v4.3.0
   System.Diagnostics.Tracing v4.3.0
      Microsoft.NETCore.Platforms v1.1.0
      System.Runtime v4.3.0
      Microsoft.NETCore.Platforms v1.1.0
      System.Runtime v4.3.0
      Microsoft.NETCore.Platforms v1.1.0
      System.Runtime v4.3.0
      Microsoft.NETCore.Platforms v1.1.0
      System.Runtime v4.3.0
      Microsoft.NETCore.Platforms v1.1.0
      System.Runtime v4.3.0
``` 
