Console.Clear();
const int STRINGSIZE = 3;
int SizeArr;
do
{
  Console.WriteLine("Введите размер массива >>>");
} while (!int.TryParse(Console.ReadLine(), out SizeArr));

string[] strArr = new string[SizeArr];
void FillArr(string[] arr)
{
  int i = 0;
  while (i < arr.Length)
  {
    Console.WriteLine($"Введите {i + 1} значение -> Enter");
    string str = (string)Console.ReadLine()!;
    arr[i] = str;
    i++;
  }
}
string[] GetArrStr(string[] arr, int SizeArr)
{
  string[] temp = new string[SizeArr];
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i].Length <= STRINGSIZE)
    {
      temp[i] = arr[i];
    }
  }
  return temp;
}

string[] GetNormArr(string[] arr)
{
  int count = 0;
  int index = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] != null)
    {
      count++;
    }
  }
  int newLength = count;
  string[] res = new string[newLength];
  for (int j = 0; j < arr.Length; j++)
  {
    if (arr[j] != null)
    {
      res[index] = arr[j];
      index++;
    }
  }
  return res;
}

void PrintArray(string[] arr)
{
  int i = 0;
  string separator = String.Empty;
  Console.Write("[");
  while (i < arr.Length)
  {
    Console.Write(separator);
    Console.Write(arr[i]);
    separator = ", ";
    i++;

  }
  Console.Write("]");
}
FillArr(strArr);
PrintArray(GetNormArr(GetArrStr(strArr, SizeArr)));
