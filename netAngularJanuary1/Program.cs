
/*
 * 
 * 1 - C# programlama dili nedir, nerelerde kullanılır?
 * 
 *   Microsoft tarafından geliştirilen C tabanlı programlama dilidir. Nesne yönelimli ve tip güvenli bir dildir. 
 *   Mobil uygulamalar, web siteleri, oyunlar, gömülü yazılımlar, masaüstü uygulamaları vb. alanlarda kullanılır.
 *   
 * 2 - Bir programın çalışması için temel bileşenler nelerdir?
 * 
 *      - Programı çalıştıracak bir işlemci.
 *      - Programın üzerinde çalışağı ram.
 *      - Programı depolayacak sabit disk.
 *      - Programı makine diline çevirecek derleyici.
 *      - Programın grafik işlem ihtiyacına göre bir grafik kartı.
 *      
 * 3 - Kullanıcıdan adını alıp ekrana yazdıran program.
 * */

Console.Write("İsim giriniz: ");

string? Name = Console.ReadLine();

Console.WriteLine($"İsminiz: {Name}");