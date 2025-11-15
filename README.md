Di dalam sebuah game bertemakan fantasy mediaval. Terdapat sebuah gerbang yang menjaga seluruh rahasia dari sebuah ramuan sihir. Gerbang tersebut akan terbuka bilamana player memiliki pedang legendaris dan armor raja atau kunci ksatria. Gerbang ini juga akan terbuka bilamana player membawa pedang legendaris dan kunci ksatria. Tetapi gerbang akan secara langsung menyerang player ketika player hanya membawa pedang legendaris atau armor raja. Dan juga gerbang menghilang tanpa jejak ketika player tidak membawa kedua hal tersebut.

p = player memiliki pedang legendaris
q = player memiliki armor raja
r = player memiliki kunci ksatria

a = gerbang terbuka untuk player
b = gerbang menyerang player
c = gerbang menghilang dari penglihatan player

a -> ((p ^ q) v r)
b -> (p v q)
c -> ((~p ^ ~q) ^ ~r)

Di sini terdapat 4 bug di mana gerbang terbuka dan gerbang menyerang, benar secara bersamaan. Adapun kondisinya adalah sebagai berikut:
1. p,q,r = benar
2. p,q = benar, r = salah
3. p,r = benar, q = salah
4. q,r = benar, p = salah

Masalah ini bisa diselesaikan dengan menggunakan prioritas pada penggunaan psedocode yang secara alami, membaca perintah dari atas ke bawah.

Judul
	{Gerbang merespon player}

Deskripsi
	p,q,r: bool {p -> pedang legendaris, q -> armor raja, r -> kunci ksatria}
	a,b,c: string {a,b,c -> kondisi gerbang}

Algoritma
	Input(p,q,r)
	a <- "gerbang terbuka"
	b <- "gerbang menyerang"
	c <- "gerbang mengilang"

	IF ((p AND q) OR r) then
		Output(a)
	Else
		IF (p OR q) then
			Output(b)
		Else
			IF ((Not p AND Not q) AND Not r) then
				Output(c)
			Endif
		Endif
	Endif
