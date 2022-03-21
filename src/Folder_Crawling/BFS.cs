using System;
using System.IO;
using System.Collections.Generic;

namespace Folder_Crawling
{
	public class BFS
	{
		private String filename; // Nama File yang ingin diari
		private String startingFolder; //Starting Folder
		private bool findAll; //FindAllOccurences
		private List<string[]> AdjacentVertices { get; set; }
        private List<(int, string, string)> ListDirectories {get; set; }

		//Construcor Kelas
		public BFS(String filename, String startingFolder, bool findAll)
		{
			this.filename = filename;
			this.startingFolder = startingFolder;
			this.findAll = findAll;
			this.AdjacentVertices = new List<string[]>();
            this.ListDirectories = new List<(int,string, string)>();
            this.ListDirectories.Add((0, startingFolder, startingFolder));
		}

		public int getindex(string directory) {
            for (int i = 0; i < this.ListDirectories.Count; i++) {
                if (this.ListDirectories[i].Item2 == directory) {
                    return i;
                }
            }
            return -1;
        }

		public string[] getFolders(string path) {
            DirectoryInfo directory = new DirectoryInfo(@path);
            DirectoryInfo[] directories = directory.GetDirectories();

            string[] listFolder = new string[directories.GetLength(0)];
            int ptr = 0;
            foreach(DirectoryInfo folder in directories) {
                listFolder[ptr] = folder.Name;
                ptr++;
            }
            return listFolder;
        }

		public string[] getFiles(string path) {
            DirectoryInfo directory = new DirectoryInfo(@path);
            FileInfo[] files = directory.GetFiles();

            string[] listFiles = new string[files.GetLength(0)];
            int ptr = 0;
            foreach (FileInfo file in files) {
                listFiles[ptr] = file.Name;
                ptr++;
            }
            return listFiles;
        }

		public void makeGraph(string root)
        {
            string path = root;
            int ptr = 0;
            while (ptr < this.ListDirectories.Count) {
                path = this.ListDirectories[ptr].Item3;
                if (this.ListDirectories[ptr].Item1 == 0) {
                    string[] listFolder = this.getFolders(path);
                    for (int i = 0; i < listFolder.Length; i++) {
                        this.ListDirectories.Add((0, listFolder[i], path + "\\" + listFolder[i]));
                        //Console.WriteLine(listFolder[i]);
                    }

                    string[] listFiles = this.getFiles(path);
                    for (int i = 0; i < listFiles.Length; i++) {
                        this.ListDirectories.Add((1, listFiles[i], path + "\\" + listFiles[i]));
                        //Console.WriteLine(listFiles[i]);
                    }
                    string[] subdir = new string[listFolder.Length + listFiles.Length];
                    for (int i = 0; i < listFolder.Length; i++) {
                        subdir[i] = listFolder[i];
                    }
                    for (int i = 0; i < listFiles.Length; i++) {
                        subdir[i + listFolder.Length] = listFiles[i];
                    }
                    this.AdjacentVertices.Add(subdir);

                    /*
                    // for debugging
                    for (int i = 0; i < this.AdjacentVertices[ptr].Length; i++) {
                        Console.Write(this.AdjacentVertices[ptr][i] + " ");
                    }
                    Console.WriteLine();
                    */
                }
                ptr++;
            }
        }

		public void doBFS(int startVertex, string filename) {
			// This array is maintained to track the vertices that are visited
            bool[] visited = new bool[this.ListDirectories.Count];

            Queue<int> queue = new Queue<int>();

            visited[startVertex] = true;

            queue.Enqueue(startVertex);

            bool fileFound = false;
            while(queue.Count != 0)
            {
                startVertex = queue.Dequeue();
                //Console.WriteLine(startVertex);

                if (this.ListDirectories[startVertex].Item1 == 1) {
                    //Console.WriteLine(this.ListDirectories[startVertex].Item2);
                    if (this.ListDirectories[startVertex].Item2 == filename) {
                        Console.WriteLine("Path file yang dicari: ");
                        Console.WriteLine(this.ListDirectories[startVertex].Item3);
                        fileFound = true;
                        break;
                    }
                    visited[startVertex] = true;
                }
                else {
                    for (int i = 0; i < this.AdjacentVertices[startVertex].Length; i++)
                    {
                        //Console.WriteLine(this.AdjacentVertices[startVertex][i]);
                        string vertex = this.AdjacentVertices[startVertex][i];
                        int idxvertex = getindex(vertex);
                        if (!visited[idxvertex])
                        {
                            visited[idxvertex] = true;
                            queue.Enqueue(idxvertex);
                        }
                    }
                }
            }
            if (!fileFound) {
                Console.WriteLine("File tidak ditemukan");
            }
		}
		//Aku kepikirannya buat bfs nya ngisi di sini gitu, nanti dipanggil di main
		public void run()
		{
			Console.WriteLine("Masukkan path folder:");
            string root = Console.ReadLine();

            Console.WriteLine("Masukkan nama file yang ingin dicari:");
            string filename = Console.ReadLine();

            BFS g = new BFS(filename, root, false);
            g.makeGraph(root);
            
            //Console.WriteLine("List of visited nodes: ");
            g.doBFS(0, filename);
		}

	}
	
}
