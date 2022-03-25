using System;
using System.IO;
using System.Collections.Generic;

namespace Folder_Crawling
{
	public class BFS: Form1
	{
		private string filename; // Nama File yang ingin dicari
		private string startingFolder; // Starting Folder
		private bool findAll; // FindAllOccurences
        private bool found;
        private string solution;
		private List<string[]> AdjacentVertices { get; set; } // Simpul-simpul yang berdekatan (keseluruhan folder dan file yang bertetanggaan dengan current node) 
        private List<(int, string, string)> ListDirectories {get; set; } // List of tuple yang berisi seluruh folder dan file yang ada di dalam startingFolder
                                                                         // Item1 bernilai 0 jika current node berupa folder dan bernilai 1 jika berupa file
                                                                         // Item2 berisi nama folder atau file
                                                                         // Item3 berisi path dari Item2 

		//Construcor Kelas
		public BFS(String filename, String startingFolder, bool findAll)
		{
			this.filename = filename;
			this.startingFolder = startingFolder;
			this.findAll = findAll;
			this.AdjacentVertices = new List<string[]>();
            this.solution = "";
            this.ListDirectories = new List<(int, string, string)>()
            {
                (0, startingFolder, startingFolder)
            };
		}

        // Mengembalikan indeks letak directory (current node atau file atau folder) dari List ListDirectories
        // Bernilai -1 jika tidak ditemukan 
		public int GetIndex(string path) {
            for (int i = 0; i < this.ListDirectories.Count; i++) {
                if (this.ListDirectories[i].Item3.Equals(path)) {
                    return i;
                }
            }
            return -1;
        }

        // Membuat graf dengan root yaitu startingFolder
        // Mencatat seluruh tetangga dari setiap directory dimulai dari startingFolder atau root di dalam AdjacentVertices 
        // Belum menghandle findAllOccurences
		public void MakeGraph(string root)
        {
            string path = root;
            int ptr = 0;
            while (ptr < this.ListDirectories.Count) {
                path = this.ListDirectories[ptr].Item3;
                if (this.ListDirectories[ptr].Item1 == 0) {

                    string[] listFolder = Utils.getFolders(path);
                    string[] listPathFolder = new string[listFolder.Length];
                    for (int i = 0; i < listFolder.Length; i++) {
                        this.ListDirectories.Add((0, listFolder[i], path + "\\" + listFolder[i]));
                        listPathFolder[i] = path + "\\" + listFolder[i];
                    }

                    string[] listFiles = Utils.getFiles(path);
                    string[] listPathFiles = new string[listFiles.Length];
                    for (int i = 0; i < listFiles.Length; i++) {
                        this.ListDirectories.Add((1, listFiles[i], path + "\\" + listFiles[i]));
                        listPathFiles[i] = path + "\\" + listFiles[i];
                    }

                    string[] subdir = new string[listFolder.Length + listFiles.Length];
                    for (int i = 0; i < listFolder.Length; i++) {
                        subdir[i] = listPathFolder[i];
                    }
                    for (int i = 0; i < listFiles.Length; i++) {
                        subdir[i + listFolder.Length] = listPathFiles[i];
                    }
                    this.AdjacentVertices.Add(subdir);
                }
                else {
                    string[] emptyList = new string[0];
                    this.AdjacentVertices.Add(emptyList);
                }
                ptr++;
            }
        }

        // Melakukan proses pencarian file dengan nama file filename dengan algoritma Breadth First Search
        // Proses pencarian dimulai dari startVertex yang merupakan indeks dari simpul di dalam ListDirectories
		public void DoBFS(int startVertex, string filename) {
            Console.WriteLine("Path file yang dicari: ");
            // Array ini untuk menandai setiap simpul yang dikunjungi
            bool[] visited = new bool[this.ListDirectories.Count];

            Queue<int> queue = new Queue<int>();

            visited[startVertex] = true;

            queue.Enqueue(startVertex);


            while(queue.Count != 0)
            {
                startVertex = queue.Dequeue();
                Console.WriteLine("HEAD");
                Console.WriteLine(this.ListDirectories[startVertex].Item2);
                visited[startVertex] = true;

                if (this.ListDirectories[startVertex].Item1 == 1) {
                    if (this.ListDirectories[startVertex].Item2 == filename) {
                        this.solution += (this.ListDirectories[startVertex].Item3 + '\n');
                        Console.WriteLine(this.ListDirectories[startVertex].Item3);
                        this.found = true;
                        if (!findAll) {
                            break;
                        }
                    }
                }
                else {
                    if (this.AdjacentVertices[startVertex].Length > 0) {
                        for (int i = 0; i < this.AdjacentVertices[startVertex].Length; i++)
                        {
                            string vertex = this.AdjacentVertices[startVertex][i];
                            Form1.graph.AddEdge(this.ListDirectories[startVertex].Item2, GetLast(vertex));
                            int idxvertex = GetIndex(vertex);
                            if (!visited[idxvertex])
                            {   
                                visited[idxvertex] = true;
                                queue.Enqueue(idxvertex);
                            }
                        }
                    }
                }
            }
            if (!found) {
                Console.WriteLine("File tidak ditemukan");
            }
		}

        private string GetLast(string toFind)
        {
            string[] toSplit = toFind.Split('\\');
            return toSplit[toSplit.Length - 1];
        }
		//Aku kepikirannya buat bfs nya ngisi di sini gitu, nanti dipanggil di main
		public string Run()
		{
            /*
			Console.WriteLine("Masukkan path folder:");
            string root = Console.ReadLine();
        
            Console.WriteLine("Masukkan nama file yang ingin dicari:");
            string filename = Console.ReadLine();
            */

            BFS g = new BFS(this.filename, this.startingFolder, false);
            this.MakeGraph(this.startingFolder);
            
            Console.WriteLine("List of visited nodes: ");
            this.DoBFS(0, this.filename);
            return this.solution;
        }

	}
	
}
