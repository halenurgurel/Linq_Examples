# LINQ Uygulaması: Rastgele Sayılar Üzerinden Veri Filtreleme

Bu projede, C# dilinde `List<int>` yapısıyla -50 ile 50 arasında rastgele üretilmiş 10 sayılık bir liste üzerinde LINQ kullanılarak çeşitli filtreleme işlemleri yapılmaktadır.

## 🎯 Projenin Amacı

- LINQ (Language Integrated Query) sorgularını temel düzeyde uygulamak
- Filtreleme ve dönüşüm işlemleriyle pratik yapmak
- `foreach`, `Where`, `Select` gibi temel ifadeleri öğrenmek

## 🔧 Kullanılan Teknolojiler

- .NET (Console App)
- C#
- LINQ

## 🚀 Program Ne Yapar?

1. -50 ile 50 arasında rastgele 10 sayı üretir
2. Bu liste üzerinde şu LINQ işlemlerini uygular:

### LINQ Sorguları:

- **Tüm Sayılar**  
  Rastgele üretilen 10 sayıyı yazdırır

- **Çift Sayılar**  
  `% 2 == 0` koşulu ile filtrelenmiş sayılar

- **Tek Sayılar**  
  `% 2 != 0` koşulu ile filtrelenmiş sayılar

- **Negatif Sayılar**  
  `< 0` koşuluna göre negatif olanlar

- **Pozitif Sayılar**  
  `> 0` koşuluna göre pozitif olanlar

- **15 < Sayı < 22**  
  Hem 15’ten büyük hem 22’den küçük olan sayılar

- **Sayıların Kareleri**  
  Tüm sayıların karesi alınarak yeni bir liste oluşturulur

## 🧪 Örnek Çıktı

```bash
Tüm Sayılar: -42 7 19 22 -15 0 4 33 -3 11

Çift Sayılar: -42 0 4 22

Tek Sayılar: 7 19 -15 33 -3 11

Negatif Sayılar: -42 -15 -3

Pozitif Sayılar: 7 19 22 4 33 11

15'den büyük 22'den küçük sayılar: 19

Listedeki sayıların karesi: 1764 49 361 484 225 0 16 1089 9 121
