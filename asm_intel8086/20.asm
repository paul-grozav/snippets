;orice ocupa spatiu putem spune ca este o zona
;orice are dimensiune(pozitiva) putem spune ca este o zona
;astfel ca un obiect zero-dimensional (0D) adica un punct ... este o zona dintr-un spatiu(plan)
;un obiect unidimensional (1D) adica o dreapta sau semidreapta, segment ... ele toate sunt o zona dintr-un spatiu(plan)(spunem ca un punct apartine dreptei daca se afla in acea zona pe care o numim dreapta)
;un obiect bidimensional (2D) adica o linie serpuita(dintr-un plan) sau un plan sau o bulina(bulina=cerc+interiorul)... sunt o zona dintr-un spatiu spunem despre un triunghi ca apartine unui plan daca se afla in zona aceea pe care noi o numim plan)
;un obiect tridimensional (3D) spre exemplu o vaza este o zona dintr-un spatiu (camera mea-care e la randul ei o zona) ... spunem ca in vaza este apa daca in interiorul zonei delimitata de ceea ce noi numim vaza (altfel spus in interiorul vazei) se afla apa (apa desigur ese o zona in care se plimba bacteriile :) )
;-------- sunt interesante zonele astea :) ---------
;oare ce vrea sa spuna enuntul prin "zona" ? ...
;Vorbim despre memoria RAM ca despre un "tabel" ... avand coloane si linii deci putem spune ca este o zona bidimensionala
;orice zona bidimensionala contine zone unidimensionale
;orice zona unidimensionala contine zone fara dimensiune
;in RAM o zona bidimensionala ar putea fi reprezentata printr-o matrice (inaltime, latime) -- echivalentul planului
;o zona unidimensionala ar putea fi un vector (care are doar lungime) -- echivalentul dreptei
;o zona zero-dimensionala poate fi o celula de memorie adica o pozitie din memorie spre exemplu 500h:0h -- echivalentul punctului
;... de asemenea o zona ar putea fi si multimea de celule {500h:0h, 504h:Ah, 1h:29h, 50Eh:0h} (desi ma indoiesc ca se refera la asa ceva enuntul)
;----------
;vom lucra totusi in continuare cu o matrice. Adica vom copia o matrice dintr-o zona in alta
;------------------------------------------------------------------------------------------------------------------

;Pentru ca nu s-a dat dimensiunea matricii vom considera o matrice de 3 pe 3 care are coltul din stanga sus la adresa 501h:1h
;iau o matrice asa de mica pentru ca o voi crea manual

mov ax, 501h
mov ds, ax
mov [1h], 9

mov ax, 502h
mov ds, ax
mov [1h], 8

mov ax, 503h
mov ds, ax
mov [1h], 7

mov ax, 501h
mov ds, ax
mov [2h], 6

mov ax, 502h
mov ds, ax
mov [2h], 5

mov ax, 503h
mov ds, ax
mov [2h], 4

mov ax, 501h
mov ds, ax
mov [3h], 3

mov ax, 502h
mov ds, ax
mov [3h], 2

mov ax, 503h
mov ds, ax
mov [3h], 1



;----- vom copia aceasta matrice in zona de 3 pe 3 care are coltul din stanga sus la pozitia 505h:5h
;este important sa observam o formula pentru a trece de la pozitia i,j din pozitia initiala la pozitia a,b in pozitia finala 
;a=i+4, b=j+4
;altfel spus elementul de la linia i si coloana j va fi pus la linia i+4 si coloana j+4 (adica pus SI acolo ... nu va fi mutat)
;cu aceasta formula treaba este simpla va trebui o singura data sa ne plimbam prin matricea initiala
mov cx, 3; pentru ca matricea noastra care vrem sa o copiem are 3 linii
linie:

	mov bx, cx; pune numarul liniei (cx) in bx pentru a putea folosi cx la loop-ul coloanelor
	
	mov cx, 3; pentru ca matricea care vrem sa o copiem are 3 coloane
	coloana:
	
		;pentru fiecare element, deci, trebuie sa il citim din memorie de la adresa initiala,
		;sa il punem intr-un registru(ax, bx, cx, dx) ... in care putem
		;sa schimbam apoi linia si coloana si sa il punem la noua pozitie 
		
		;mai intai sa il citim de la pozitia initiala
		;setam DS-ul
		mov ax, 500h
		add ax, cx
		mov ds, ax; ds = 500h + numarul coloanei ... se obtine (503h, 502h si 501h)
		
		mov dx, [bx]; pune in dx elementul de la coloana DS si linia bx ... acest element il copiem
		
		;schimbam coloana
		add ax, 4; ax e coloana initiala la care era elementul ... conform formulei stabilite mai sus la coloana initiala mai adaugam 4
		mov ds, ax
		
		mov [bx+4], dx; pune la coloana DS = 500h + numarulColoanei + 4 si linia bx + 4 elementul care il copiem
	
	loop coloana; pentru fiecare din cele 3 coloane
	
	mov cx, bx; pune in cx din nou numarul liniei pentru a nu da peste cap loop-ul linilor

loop linie; pentru fiecare din cele 3 linii
hlt