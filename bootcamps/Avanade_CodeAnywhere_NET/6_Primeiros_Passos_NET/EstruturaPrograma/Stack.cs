using System.Collections;
namespace EstruturaPrograma
{
    public class Stack
    {
        // LIFO Last In First Out

        private ArrayList stack = new ArrayList();
        private int len = 0;
        public int Len 
        {
            get { return this.len; }
        }

        public Stack() {}
        // torna instancia acessivel via index
        /*public int this[int ind]
        {
            
        }*/

        public void Push(object obj){
            this.stack.Add(obj);
            len++;
        }
        public object Pop(){
            if (len > 0)
            {
                len--;
                object o = stack[len];
                stack.RemoveAt(len);
                return o;
            }
            return null;
        }
    }
}