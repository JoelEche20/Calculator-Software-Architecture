class Calculate{

    private int num;
    private int num2;

    public int numero
        {
            get { return num; }
            set { num = value; }
        }
 
    public int numero2
    {
        get { return num2; }
        set { num2 = value; }
    }

    public int add(){
        return num+num2;
    }

    public int substrac(){
        return num-num2;
    }

    public int multiply(){
        return num*num2;
    }

    public int divide(){
        return num/num2;
    }

    public int residue(){
        return num%num2;
    }

}