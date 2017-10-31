using NuGet;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NugetReferences
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the local repo folder: ");
            var repoFolder = Console.ReadLine();

            while (true)
            {
                Console.Write("Enter the dependency id matching criteria: ");
                var criteria = Console.ReadLine();

                Console.Write("Enter the maximum depth for the dependency tree: ");
                var maxDepth = int.Parse(Console.ReadLine());

                var repo = new LocalPackageRepository(repoFolder);
                IQueryable<IPackage> packages = repo.GetPackages().Where(p => p.Id.Contains(criteria));

                OutputGraph(repo, packages, 0, maxDepth);

                Console.ReadKey();
            }
        }

        static void OutputGraph(LocalPackageRepository repository, IEnumerable<IPackage> packages, int depth, int maxDepth)
        {
            foreach (IPackage package in packages)
            {
                Console.WriteLine("{0}{1} v{2}", new string(' ', depth * 3), package.Id, package.Version);

                IList<IPackage> dependentPackages = new List<IPackage>();
                foreach (var dependencySet in package.DependencySets)
                {
                    foreach (var dependency in dependencySet.Dependencies)
                    {
                        var dependentPackage = repository.FindPackage(dependency.Id, dependency.VersionSpec, true, true);
                        if (dependentPackage != null)
                        {
                            dependentPackages.Add(dependentPackage);
                        }
                    }
                }

                if (depth < maxDepth)
                {
                    OutputGraph(repository, dependentPackages, depth + 1, maxDepth);
                }
            }
        }
    }
}

