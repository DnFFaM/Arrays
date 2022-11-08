//using ArrayTout.ArraysEks;
//string? tekst =
//"For norland produce age wishing. To figure on it spring season up. Her provision acuteness had excellent two why intention. As called mr needed praise at. Assistance imprudence yet sentiments unpleasant expression met surrounded not. Be at talked ye though secure nearer.\r\n\r\nAn country demesne message it. Bachelor domestic extended doubtful as concerns at. Morning prudent removal an letters by. On could my in order never it. Or excited certain sixteen it to parties colonel. Depending conveying direction has led immediate. Law gate her well bed life feet seen rent. On nature or no except it sussex.\r\n\r\nFriendship contrasted solicitude insipidity in introduced literature it. He seemed denote except as oppose do spring my. Between any may mention evening age shortly can ability regular. He shortly sixteen of colonel colonel evening cordial to. Although jointure an my of mistress servants am weddings. Age why the therefore education unfeeling for arranging. Above again money own scale maids ham least led. Returned settling produced strongly ecstatic use yourself way. Repulsive extremity enjoyment she perceived nor.\r\n\r\nWe diminution preference thoroughly if. Joy deal pain view much her time. Led young gay would now state. Pronounce we attention admitting on assurance of suspicion conveying. That his west quit had met till. Of advantage he attending household at do perceived. Middleton in objection discovery as agreeable. Edward thrown dining so he my around to.\r\n\r\nStyle too own civil out along. Perfectly offending attempted add arranging age gentleman concluded. Get who uncommonly our expression ten increasing considered occasional travelling. Ever read tell year give may men call its. Piqued son turned fat income played end wicket. To do noisy downs round an happy books.\r\n\r\nOf recommend residence education be on difficult repulsive offending. Judge views had mirth table seems great him for her. Alone all happy asked begin fully stand own get. Excuse ye seeing result of we. See scale dried songs old may not. Promotion did disposing you household any instantly. Hills we do under times at first short an.\r\n\r\nExamine she brother prudent add day ham. Far stairs now coming bed oppose hunted become his. You zealously departure had procuring suspicion. Books whose front would purse if be do decay. Quitting you way formerly disposed perceive ladyship are. Common turned boy direct and yet.\r\n\r\nIn by an appetite no humoured returned informed. Possession so comparison inquietude he he conviction no decisively. Marianne jointure attended she hastened surprise but she. Ever lady son yet you very paid form away. He advantage of exquisite resolving if on tolerably. Become sister on in garden it barton waited on.\r\n\r\nPrevailed sincerity behaviour to so do principle mr. As departure at no propriety zealously my. On dear rent if girl view. First on smart there he sense. Earnestly enjoyment her you resources. Brother chamber ten old against. Mr be cottage so related minuter is. Delicate say and blessing ladyship exertion few margaret. Delight herself welcome against smiling its for. Suspected discovery by he affection household of principle perfectly he.\r\n\r\nHer extensive perceived may any sincerity extremity. Indeed add rather may pretty see. Old propriety delighted explained perceived otherwise objection saw ten her. Doubt merit sir the right these alone keeps. By sometimes intention smallness he northward. Consisted we otherwise arranging commanded discovery it explained. Does cold even song like two yet been. Literature interested announcing for terminated him inquietude day shy. Himself he fertile chicken perhaps waiting if highest no it. Continued promotion has consulted fat improving not way.\r\n";

//string[] tekstSplit = tekst.Split(' ');

////EKSAMPEL MED FOR LOOP
//int c = 0;
//for (int x = 0; x < tekstSplit.Length; x++)
//{
//    if (tekstSplit[x].ToLower().Contains("age"))
//    {
//        c++;
//    }
//}

//// EKSAMPEL MED FOREACH LOOP
//int c = 0;
//foreach (int x = 0 < tekstSplit.Length; x++)
//{
//    if (tekstSplit[x].ToLower().Contains("age"))
//    {
//        c++;
//    }
//}
//Console.WriteLine($"Antal a order 'age': {c}");




//ArrayEksampler t = new();
//int c = t.count();

//Console.WriteLine($"");

using ArrayExamples.Codes;


WordCount t = new();
int c = t.Count();

Console.WriteLine($"Antal af ordet 'type' {c}: ");

MutiDimensionalArray ma = new();
string[] result = ma.ArrayTest();
foreach (string text in result)
    Console.WriteLine(text);
