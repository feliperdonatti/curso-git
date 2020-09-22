using System;
using System.Collections.Generic;
using System.IO;

namespace Cap13_TrabalhandoComArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Aula5Exemplo1();
        }   

        public void Aula5Exemplo1()
        {
            string path = @"c:\temp\file1.txt";

            Console.WriteLine("FileName: " + Path.GetFileName(path));
            Console.WriteLine("PathSeparator:" + Path.PathSeparator);
            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path) );
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());
        }

        public void Aula4Exemplo1()
        {
            try
            {
                string sourcePath = @"c:\temp\";

                IEnumerable<string> folders = Directory.EnumerateDirectories(sourcePath, "*.*", SearchOption.AllDirectories);

                foreach (var folder in folders)
                {
                    Console.WriteLine(folder);
                }

                var files = Directory.EnumerateFiles(sourcePath, "*.*", SearchOption.AllDirectories);

                foreach (var file in files)
                {
                    Console.WriteLine(file);
                }

                Directory.CreateDirectory(sourcePath + "\\newFolder");
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Aula3Exemplo1()
        {
            string sourcePath = @"c:\temp\file1.txt";
            string targetPath = @"c:\temp\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (var line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void Aula2Exemplo1()
        {
            string path = @"c:\temp\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);

                string line = sr.ReadLine();
                Console.WriteLine(line);
            }catch(IOException e)
            {

            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
        }

        public void Aula2Exemplo2()
        {
            string path = @"c:\temp\file1.txt";
            StreamReader sr = null;

            try
            {
                sr = File.OpenText(path);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }

                
            }
            catch (IOException e)
            {

            }
            finally
            {
                if (sr != null) sr.Close();
            }
        }

        public void Aula2Exemplo3()
        {
            string path = @"c:\temp\file1.txt";

            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            Console.WriteLine(sr.ReadLine());
                        }
                    }
                }
            } catch(IOException e)
            {

            }
        }


        public void Aula1()
        {
            string sourcePath = @"c:\temp\file1.txt";
            string targetPath = @"c:\temp\file3.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(sourcePath);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
        }
    
    }
}
