using System.Collections;

namespace PluralSight
{
	public class PackageInstaller
	{
		public static void Main()
		{

		}

		public static string GetPackageInstallationOrder(string[] packagesDependencyInputs)
		{
			var stack = new Stack();
			foreach (var packagesDependencyInput in packagesDependencyInputs)
			{
				var packages = packagesDependencyInput.Split(':');
				foreach (var package in packages)
				{
					if (package.Length > 0)
					{
						stack.Push(package);
					}
				}
			}

			return BuildOutputString(stack);
		}

		private static string BuildOutputString(Stack stack)
		{
			if (stack.Count == 0)
			{
				return null;
			}
			var outputString = string.Empty;
			var totalCount = stack.Count;
			for (int count = 0; count < totalCount; count++)
			{
				if (!outputString.Contains(stack.Peek().ToString()))
				{
					outputString += "," + stack.Pop();
				}
				else
				{
					stack.Pop();
				}
			}
			return outputString.Substring(1, outputString.Length-1);
		}
	}
}
