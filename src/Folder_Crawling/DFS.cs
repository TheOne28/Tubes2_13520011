using System;

namespace Folder_Crawling
{
	public class DFS: Form1
	{
		private string filename; // Nama File yang ingin diari
		private string startingFolder { get; set; } //Starting Folder
		private int level; //level = 0 untuk pemanggilan dfs pertama
		private bool findAll; //FindAllOccurences
		private string solution { get; set; }
		private bool found;

		//Construcor Kelas
		public DFS(int level, String filename, String startingFolder, bool findAll)
		{
			this.level = level;
			this.filename = filename;
			this.startingFolder = startingFolder;
			this.findAll = findAll;
			this.found = false;
			this.solution = "";
		}

		public void doDFS(string startingFolder, string filename)
        {
			string[] split = startingFolder.Split('\\');
			string last = split[split.Length - 1];
			string[] listfiles = Utils.getFiles(startingFolder);
			foreach(string file in listfiles)
            {
				if (file == filename)
				{
					Form1.graph.AddEdge(last, file).Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
					this.solution = this.startingFolder + "\\" + file + "\n";
					this.found = true;
					Console.WriteLine(this.solution);
				}
                else
                {
					Form1.graph.AddEdge(last, file);
                }
				//Console.WriteLine(file);
			}
			string[] listfolder = Utils.getFolders(startingFolder);
			if ((!this.findAll && !this.found )|| (this.findAll ) )
				foreach(string folder in listfolder)
				{
					DFS child = new DFS(this.level + 1, this.filename, this.startingFolder + "\\" + folder, this.findAll);
					child.doDFS(child.startingFolder, filename);
					if (child.found) {
						this.found = true;
						this.solution += child.solution;
						Form1.graph.AddEdge(last, folder).Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
						if (!this.findAll) break;
					} else
                    {
						Form1.graph.AddEdge(last, folder);

					}
				}
        }
		//Aku kepikirannya buat dfs nya ngisi di sini gitu, nanti dipanggil di main
		public string run()
		{
			Console.WriteLine("Hasil Pencarian : ");
			this.doDFS(this.startingFolder, this.filename);
			if (!this.found)
            {
				Console.WriteLine("File tidak ditemukan");
				return "";
            }
            else
            {
				return this.solution;
            }
		}
	}

}
