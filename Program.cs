namespace FinalExam_64 {
    internal class Program {
        static void Main(string[] args) {
            BinaryTree<int> tree = new();
            tree.Root(1);
            tree.SetLeft(2, 0);
            tree.SetRight(3, 0);
            tree.SetLeft(4, 1);
            tree.SetRight(5, 1);

            tree.Print();
        }
    }
    internal class BinaryTree<T> {
        private readonly T[] values = new T[10];

        public BinaryTree() { }
        public BinaryTree(int size) {
            values = new T[size];
        }
        public void Root(T key) {
            values[0] = key;
        }
        public void SetLeft(T t, int root) {
            int ind = (root * 2) + 1;

            if (values[root] == null) {
                Console.Write("Can't set child at {0}, no parent found\n", ind);
            }
            else {
                values[ind] = t;
            }
        }
        public void SetRight(T t, int root) {
            int ind = (root * 2) + 2;

            if (values[root] == null) {
                Console.Write("Can't set child at {0}, no parent found\n", t);
            }
            else {
                values[ind] = t;    
            }
        }
        public void Print() {
            for (int i = 0; i < values.Length; i++) {
                if (values[i] != null)
                    Console.Write(values[i]);
                else
                    Console.Write(" ");
            }
        }
    }
}