using System.IO;

namespace SimpleFileSystem.Nodes
{
	public abstract class BaseNode
	{
		protected long Position;

		public abstract void Load(Stream stream);

	}
}
