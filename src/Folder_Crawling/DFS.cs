using System;

namespace Folder_Crawling
{
	public class DFS
	{
		private String filename; // Nama File yang ingin diari
		private String startingFolder; //Starting Folder
		private bool findAll; //FindAllOccurences

		//Construcor Kelas
		public DFS(String filename, String startingFolder, bool findAll)
		{
			this.filename = filename;
			this.startingFolder = startingFolder;
			this.findAll = findAll;
		}

		//Aku kepikirannya buat dfs nya ngisi di sini gitu, nanti dipanggil di main
		public void run()
		{

		}
	}

}
