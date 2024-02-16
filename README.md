Переработать интерфейсы

public interface IPrinter(){
  void Print();
}




class Array1(): IArrBase, IPrinter
{
  public void IPrinter.PrintArray()
  {}
}
