;am putea pune in zona RAM 500h:0h -> 509h:9h mai multe elemente (adica sa cream o matrice in zona aia) dar lasam asa
;ar trebui sa fie plina cu elemente de 0 deci sa obtinem 9x9=81 de elemente nule
;daca vrem putem decomenta urmatoarele 3 linii pentru a elimina un element nul
;mov ax, 503h
;mov ds, ax
;mov [5h], 2
;numarul de numere nule va fi salvat in ax
mov ax, 0; initial nu am gasit niciun(mie imi place sa scriu niciun in loc de nici un ^.^) element nul
mov cx, 9; pentru ca matricea noastra are 9 linii
linie:

	mov bx, cx; pentru a putea folosi cx-ul la loopul prin coloane vom salva cx-ul(numaru liniei) in bx

	mov cx, 9; pentru ca matricea noastra are 9 coloane
	coloana:
	
		;fiecare element va trebui sa fie comparat cu 0 daca este 0(nul) atunci spunem ca am mai gasit un numar nul
		;dar mai intai sa citim elementul ... sa setam DS-ul
		mov dx, 500h
		add dx, cx
		sub dx, 1; avand in vedere ca cx ia valori de la 9 la 1 (1 reprezentand prima coloana din matrice)
		;... la noi in memorie prima coloana se afla la DS=500h iar nu 501h deci trebuie sa mai scadem o unitate
		mov ds, dx; ds = 500h + (cx -1)
		
		cmp [bx], 0; compara elementul de la coloana DS si linia bx cu 0
		jz e0; daca elementul e 0 sari la "e0" :)
		jmp nuE0; daca nu e 0 sari la "nuE0"
		e0:
		add ax, 1; daca e 0 atunci am mai gasit un element null si crestem numarul de elemente nule gasite (ax)
		nuE0:
	
	loop coloana; pentru fiecare din cele 9 coloane a matricei
		
	mov cx, bx; punem inapoi in cx numarul liniei pentru ca sa nu se incurce loop-ul cu linia

loop linie; pentru fiecare din cele 9 linii
hlt