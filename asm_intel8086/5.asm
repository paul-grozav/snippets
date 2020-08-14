;Observatie1: pentru a calcula n! vom folosi ciclul LOOP care se va "plimba" de la o valoare cx=n pana la 1
;Observatie2: cx apoi va scadea cu o unitate cx = 0 si deoarece cx=0 adica a ajuns la sfarsit => nu se va mai inmulti cu 0

;planuim sa stocam rezultatele partiale in ax. Altfel spus in ax vom calcula produsul ax = 1 * 2 * 3 * ... * n

mov ax, 1; pentru ca in ax vom calcula produsul vom pune ca valoare initiala 1(element neutru al inmultirii)
mov cx, 4; acesta valoare reprezinta n
calculeaza:

	; aceasta eticheta "calculeaza" se repeta de cx ori ... pentru cx, pentru cx-1, pentru cx-2, ..., pentru 1
	; Atentie! pentru ca cx "coboara" de la 4 pana la 0 vom obtine ax = 4 * 3 * 2 * 1 ... dar inmultirea e comutativa
	mul cx; ax = ax * cx  ... prima oara se inmulteste cu cx care e 4 apoi cu cx care e 3 ... si tot asa
	
	;pana aici avem in ax rezultatul partial.
	;Trebuie sa salvam acest rezultat in memorie intr-o lista(vector) ... care incepe de la pozitia 500h:0h
	;Cand cx a coborat de la n la t(n>t>1) in ax vom avea ax = n*(n-1)*(n-2)*..*t
	;Adica daca cx a coborat de la 4 la 3 noi vom avea in ax = 4*3 ...
	;Atentie! : cand cx a ajuns la valoarea 1 vom obtine ax = n*(n-1)*(n-2)* ... *3*2*1 = n!
	;deci daca am vrea sa punem ax(rezultatul partial) in memorie la adresa 500+cx completarea va incepe de la 504 apoi 503, 502, 501
	;dar la 500 nu se va ajunge pentru ca eticheta "calculeaza" nu se executa pentru cx=0
	;se va obtine ceva de genul:
	;--500h-----------501h-----------------502h-------------503h---------- ... -------500+cx h-----
	;        |  n!=n*(n-1)*..*2*1  |  n*(n-1)*...*2  |  n*(n-1)*...*3  |   ...    n*(n-1)*...*cx
	;--------------------------------------------------------------------- ... --------------------
	;Se observa ca la 500h:0h nu avem nicio valoare.
	;Cum s-a cerut sa completam de la 500h:0h vom modifica formula generala: punem rezultatul partial ax = n*(n-1)*...*cx la adresa 500+(cx-1) h
	;astfel ca vom muta tot vectorul cu o casuta mai in dreapta
	;se va obtine ceva de genul:
	;---------500h---------------501h---------------502h--------- ... -----500+(cx-1) h-----
	;  n!=n*(n-1)*..*2*1  |  n*(n-1)*...*2  |  n*(n-1)*...*3  |   ...    n*(n-1)*...*cx
	;------------------------------------------------------------ ... ----------------------
	
	;asa vom face, deci, punem rezultatul partial ax = n*(n-1)*...*cx la adresa 500+(cx-1) h
	;calculam valoarea coloanei(ds) in bx = 500+cx-1 h
	mov bx, 500h; bx = 500h
	add bx, cx; bx = bx + cx = 500 + cx
	sub bx, 1; bx = bx - 1 = 500 + cx - 1
	mov ds, bx; setam coloana ca fiind 500+(cx-1) h
	
	mov [0], ax; punem rezultatul partial ax = n*(n-1)*...*cx la adresa 500+(cx-1) h
	

loop calculeaza; scade pe cx cu o unitate. Daca cx este diferit de 0 mergi sus si mai fa odata eticheta calculeaza ... altfel mergi mai departe

hlt