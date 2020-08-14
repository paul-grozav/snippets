;mai intai sa cream matricea (de 3x3 incepand de la 501h:1h)

mov ax, 501h
mov ds, ax
mov [1h], 1

mov ax, 502h
mov ds, ax
mov [1h], 2

mov ax, 503h
mov ds, ax
mov [1h], 3

mov ax, 501h
mov ds, ax
mov [2h], 4

mov ax, 502h
mov ds, ax
mov [2h], 5

mov ax, 503h
mov ds, ax
mov [2h], 6

mov ax, 501h
mov ds, ax
mov [3h], 7

mov ax, 502h
mov ds, ax
mov [3h], 8

mov ax, 503h
mov ds, ax
mov [3h], 9


           
;-------- DE AICI DEFAPT INCEPE INMULTIREA MATRICEI CU NUMARUL (numar ales de noi)-----------
mov cx, 3; pentru ca matricea are 3 linii
linie:

	mov bx, cx; pentru ca avem nevoie de cx la loop-ul coloanelor vom salva cx in bx
	
	mov cx, 3; pentru ca matricea are 3 coloane
	coloana:
	
		;trebuie sa citim elementul de pe pozitia (500h+cx):bx, sa il inmultim cu numarul si sa il punem la loc
		;pentru ca inmultirea (mul) se face la ax vom citi elementul in ax
		;mai intai sa setam DS-ul
		mov ax, 500h;folosim ax-ul pentru a seta DS-ul
		add ax, cx
		mov ds, ax; ds = 500h + cx adica 500h + numarul coloanei la care suntem in matrice (500h+3, 502h sau 501h)
		
		mov ax, 0; pentru ca avem de gand sa lucram cu al trebuie sa golim ah deci vom goli tot ax si vom seta apoi al
		mov al, [bx]; pune in al(jumatatea lui ax) numarul din matrice de la coloana DS si linia bx ... folosim al pentru a citi un numar pe 16 biti .. daca am folosi ax s-ar citi numere prea mari
		
		mov dx, 9; 9 este numarul cu care inmultim matricea
		mul dx; inmulteste elementul cu numarul dx=9 ... ax = ax * 9
		
		mov [bx], al; punem inapoi in matrice elementul din al (care a fost inmultit cu 9) daca punem din ax va scrie in RAM 32 de biti ceea ce va duce la pierderea unor date din matrice
	
	loop coloana;pentru fiecare din cele 3 coloane ale matricei
	
	mov cx, bx; pentru ca nu mai avem nevoie de cx la coloane ii vom da din nou valoarea din bx (adica numarul liniei)

loop linie;pentru fiecare din cele 3 linii
hlt