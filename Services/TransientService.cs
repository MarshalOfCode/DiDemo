public class TransientService : ITransientService
{
    private List<int> numberList = new List<int>();
    public List<int> getList()
    {
        return numberList;
    }

    public void addList(int number)
    {
        numberList.Add(number);
    }
}