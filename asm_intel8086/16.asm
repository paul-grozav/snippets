;Mai intai sa cream matricea (O vom face de la 501h:1h de 3 pe 3 si o vom umple manual pentru a avea elemente mai diverse)

;Elementul de la Linia 1 Coloana 1
mov ax, 501h
mov ds, ax
mov [1h], 1

;L1 C2
mov ax, 502h
mov ds, ax
mov [1h], 2

;L1 C3
mov ax, 503h
mov ds, ax
mov [1h], 3

;L2 C1
mov ax, 501h
mov ds, ax
mov [2h], 4

;L2 C2
mov ax, 502h
mov ds, ax
mov [2h], 5

;L2 C3
mov ax, 503h
mov ds, ax
mov [2h], 6

;L3 C1
mov ax, 501h
mov ds, ax
mov [3h], 7

;L3 C2
mov ax, 502h
mov ds, ax
mov [3h], 8

;L3 C3
mov ax, 503h
mov ds, ax
mov [3h], 9


;----------- DE AICI INCEPE DEFAPT SUMA ELEMENTELOR DE PE DIAGONALA PRINCIPALA----------------
;Daca avem o matrice descrisa de elemente aij atunci elementele de pe diagonala principala sunt elementele care au
;i=j adica elementele a11, a22, a33, ...
;Noi ne vom plimba prin toata matricea cu 2 loop-uri si vom compara numarul liniei (i) cu numarul coloanei (j) si daca
;sunt egale atunci vom adauga la suma elementul de pe pozitia respectiva

mov ax, 0; aici vom tine minte suma elementelor de pe diagonala principala
mov cx, 3; avem 3 linii in matrice(noi am facut-o asa)
linie:

	mov bx, cx; punem numarul liniei(cx) in bx pentru a ne elibera cx-ul pentru urmatorul loop
	mov cx, 3; pentru ca avem 3 coloane in matricea facuta de noi
	coloana:
	
		cmp bx, cx; trebuie sa comparam linia(bx) cu coloana(cx) si daca sunt egale sa adaugam elementul in suma
		jz suntEgale; daca bx=cx atunci sari la eticheta "suntEgale" (adica sari peste jmp nuSuntEgale)(adica nu sari la nuSuntEgale)
		jmp nuSuntEgale; daca se ajunge aici inseamna ca nu a sarit la "suntEgale" deci bx e diferit de cx ... deci avem nimic de facut(nu trebuie sa adaugam in suma)
		suntEgale:
		;daca s-a ajuns aici inseamna ca bx=cx deci elementul este pe diagonala principala deci il vom adauga in suma(la ax)		
		;dar mai intai sa setam DS-ul pentru a putea accesa elementul din memoria RAM
		mov dx, 500h
		add dx, cx
		mov ds, dx; ds = 500h + cx adica 500h + numarul coloanei din matrice (3, 2 sau 1)
		
		;urmatoarea comanda se executa gresit pentru ca citeste 32 de biti adica ambele numere intr-unul singur;add ax, [bx]; adauga la ax(la suma) elementul de pe coloana specificata si randul bx(bx reprezinta numarul liniei din matrice)
		mov dx, 0;golim tot dx-ul sa nu ramana cumva ceva in dh
		mov dl, [bx]; acum am citit 16 biti din RAM adica doar primul numar
		add ax, dx; adauga la suma numarul citit(elementul de pe diagonala principala)
		nuSuntEgale:;aici se sare cand nu trebuie sa adaugam elementul in suma
			
	loop coloana;pentru fiecare din cele 3 coloane            
	mov cx, bx; acum pentru ca nu mai avem nevoie de cx punem in cx din nou numarul liniei pentru a nu se incurca loop-ul responsabil cu linile

loop linie; pentru fiecare din cele 3 linii
hlt