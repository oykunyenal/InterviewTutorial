using InterviewTutorial.BinaryConvertionOfNumber.Operation;

ConvertNumberToBinary ConvertNumberToBinary = new ConvertNumberToBinary();

string result = ConvertNumberToBinary.ConvertNumberToBinaryRepresentation(20);

Console.WriteLine("Binary Representation Of Number : " + result);

int resultForZerosCount = ConvertNumberToBinary.GetCountOfZerosInString(result);

Console.WriteLine("How many zeros in binary string : " + resultForZerosCount);

int resultForOnesCount = ConvertNumberToBinary.GetCountOfOnesInString(result);

Console.WriteLine("How many ones in binary string : " + resultForOnesCount);
