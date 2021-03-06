using MonoDevelop.Core;
using MonoDevelop.D.Building;
using MonoDevelop.Projects;

namespace MonoDevelop.D
{
	public class DLanguageBinding: ILanguageBinding
	{
		public static DLanguageBinding Instance { get; private set; }

		public DLanguageBinding()
		{
			Instance = this;

			// Init compiler configurations if not done yet
			if (!DCompilerService.IsInitialized)
				DCompilerService.Load();
		}

		~DLanguageBinding()
		{
			DCompilerService.Instance.Save();
		}

		public static bool IsDFile(string fileName)
		{
			return fileName.EndsWith(".d", System.StringComparison.OrdinalIgnoreCase) || fileName.EndsWith(".di", System.StringComparison.OrdinalIgnoreCase);
		}

		public FilePath GetFileName(FilePath fileNameWithoutExtension)
		{
			return fileNameWithoutExtension.ChangeExtension(".d");
		}

		public bool IsSourceCodeFile(FilePath fileName)
		{
			return IsDFile(fileName);
		}

		public string Language {
			get {
				return "D";
			}
		}

		public string SingleLineCommentTag {
			get {
				return "//";
			}
		}

		public string BlockCommentStartTag {
			get {
				return "/*";
			}
		}

		public string BlockCommentEndTag {
			get {
				return "*/";
			}
		}
	}
}

