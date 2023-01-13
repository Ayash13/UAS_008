using System;


    class Node
    {
        public string info;
        public Node next;
        public Node(string i, Node n)
        {
            info = i;
            next = n;

        }

        public Node(string element, object value)
        {
 
        }
    }
    class Stacks
    {
        Node top;
        public Stacks()
        {
            top = null;
        }
        bool empty()
        {
            if (top == null)
                return (true);
            else
                return (false);
        }
        public void push(string element)
        {
            Node fresh;
            fresh = new Node(element, null);

            fresh.next = top;
            top = fresh;
            Console.WriteLine(" " + element );

        }
        public void pop()
        {
            Console.WriteLine("The popped elemet is : " + top.info);
            top = top.next; //Make top point to the next node in sequence
        }
        public void display()
        {
            Node tmp;
            if (empty()) //If stack is empty
                Console.WriteLine("Stack is empty");
            else
            {
                //Travers the list from beginning till end
                for (tmp = top; tmp != null; tmp = tmp.next)
                {
                    Console.WriteLine(tmp.info);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Stacks s = new Stacks();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("======= Data Toko =======");
                Console.WriteLine("1. Masukan Barang");
                Console.WriteLine("2. Hapus barang");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice : ");
                string sInput = Console.ReadLine();
                char ch = Convert.ToChar(sInput == "" ? "0" : sInput);
                switch (ch)
                {
                    case '1':
                        Console.WriteLine("Enter ID : ");
                        string idbar = Console.ReadLine();
                        Console.WriteLine("Nama Barang : ");
                        string nama = Console.ReadLine();
                        Console.WriteLine("jenis Barang : ");
                        string jenis = Console.ReadLine();
                        Console.WriteLine("Harga Barang : ");
                        string harga = Console.ReadLine();
                        s.push(idbar);
                        s.push(nama);
                        s.push(jenis);
                        s.push(harga);
                        break;
                    case '2':
                        if (s.empty())
                        {
                            Console.WriteLine("Stack empty");
                            break;
                        }
                        s.pop();
                        break;
                    case '3':
                        s.display();
                        break;
                    case '4':
                        return;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }






// JAWABAN TEORI

/* 
 2. Menggunakan Stack dan linked list, karena dapat menyinpan data sekaligus 


 3. Perbedaan antara array dan linked list : 

 A) Array digunakan untuk menyimpan data, tetapi jumlah data yang bisa ditampung oleh array hanya terbatas. 
    Array digunakan ketika kita ingin menyimpan data dalam jumlah yang sedikit, seperti ingin menyimpan nim.
 B) List digunakan untuk menyimpan data yang lebih bervariasi. Linked list digunakan ketika kita ingin mengimplementasikan
    algoritma struktur data lain seperti, stacks & queues, dan binary trees.

 4. Enqueue dan Dequeue

 5. Sibling : 41 & 74
    Indorder : Pertama menentukan root, root adalah angka pertama yang dimasukan, lalu proses subtree dari sebelah kiri (41)
               Jika subtree kiri tidak null, maka lanjut ke sebelah kiri dari (41) yaitu (16).
               Setelah itu lanjut bergeser ke subtree dari (16), yaitu (25). Setelah itu naik lagi ke (41) untuk selanjutnya
               bergeser ke 53, dan seterusnya. Jadi urutannya adalah 

               16, 25, 41, 46, 42, 53, 55, 60, 65, 63, 62, 64, 65, 70, 74
 
 
 */