using System;
using System.IO;
using System.Collections.Generic;

namespace Folder_Crawling
{
	public class BFS
	{
		private String filename; // Nama File yang ingin dicari
		private String startingFolder; // Starting Folder
		private bool findAll; // FindAllOccurences
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
            this.ListDirectories = new List<(int,string, string)>();
            this.ListDirectories.Add((0, startingFolder, startingFolder));
		}

        // Mengembalikan indeks letak directory (current node atau file atau folder) dari List ListDirectories
        // Bernilai -1 jika tidak ditemukan 
		public int getindex(string directory) {
            for (int i = 0; i < this.ListDirectories.Count; i++) {
                if (this.ListDirectories[i].Item2 == directory) {
                    return i;
                }
            }
            return -1;
        }

        // Membuat graf dengan root yaitu startingFolder
        // Mencatat seluruh tetangga dari setiap directory dimulai dari startingFolder atau root di dalam AdjacentVertices 
        // Belum menghandle findAllOccurences
		public void makeGraph(string root)
        {
            string path = root;
            int ptr = 0;
            while (ptr < this.ListDirectories.Count) {
                if (ptr != 0)
                path = this.ListDirectories[ptr].Item3;
                if (this.ListDirectories[ptr].Item1 == 0) {
                    string[] listFolder = Utils.getFolders(path);
                    for (int i = 0; i < listFolder.Length; i++) {
                        this.ListDirectories.Add((0, listFolder[i], path + "\\" + listFolder[i]));
                        //Console.WriteLine(listFolder[i]);
                    }

                    string[] listFiles = Utils.getFiles(path);
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

        // Melakukan proses pencarian file dengan nama file filename dengan algoritma Breadth First Search
        // Proses pencarian dimulai dari startVertex yang merupakan indeks dari simpul di dalam ListDirectories
		public void doBFS(int startVertex, string filename) {
			// Array ini untuk menandai setiap simpul yang dikunjungi
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
			/*Console.WriteLine("Masukkan path folder:");
            string root = Console.ReadLine();
        
            Console.WriteLine("Masukkan nama file yang ingin dicari:");
            string filename = Console.ReadLine();
            
            BFS g = new BFS(filename, root, false);*/
            this.makeGraph(this.startingFolder);
            
            Console.WriteLine("List of visited nodes: ");
            this.doBFS(0, this.filename);
		}

	}
	
}
