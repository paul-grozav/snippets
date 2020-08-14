;Observatie1: pentru a calcula a^n = a*a*...*a de n ori vom folosi ciclul LOOP care se va "plimba" de la o valoare cx=n pana la 1
;Observatie2: cx apoi va scadea cu o unitate cx = 0 si deoarece cx=0 adica a ajuns la sfarsit => nu se va mai inmulti inca odata cu a

;planuim sa stocam rezultatele partiale in ax. Altfel spus in ax vom calcula produsul ax = 1 * 2 * 3 * ... * n

mov ax, 1; pentru ca in ax vom calcula produsul vom pune ca valoare initiala 1(element neutru al inmultirii)
mov cx, 4; acesta valoare reprezinta n
calculeaza:

	; aceasta eticheta "calculeaza" se repeta de cx ori ... pentru cx, pentru cx-1, pentru cx-2, ..., pentru 1
	;Observatie: cand cx va fi coborat de la valoarea initiala n la valoarea t in ax noi vom avea produsul ax = a*a*...*a de (n-t) ori
	;urmatorul 2 reprezinta baza(a) din expresia a^n
	mov dx, 2; pentru ca nu putem inmulti direct cu 2 scriind mul 2 vom pune 2 in dx si vom inmulti cu dx=2
	mul dx; ax = ax * 2  ... adica tot dublez valoarea lui ax *2*2 ... de cx ori
	;dar cum cx reprezinta puterea n la care vrem sa ridicam pe a vom obtine in ax = a*a*..*a de n ori
	
	;punem rezultatul partial ax = a*a*...*a de n ori la adresa 500+(cx-1) h
	;vom obtine ceva de genul:
	;--500h------501h-----502h----- ... -----500+(cx-1)--
	;   a^n  | a^(n-1) | a^(n-2) |  ...   |     a^1 = a
	;------------------------------ ... -----------------
	;calculam valoarea coloanei(ds) in bx = 500+cx-1 h
	mov bx, 500h; bx = 500h
	add bx, cx; bx = bx + cx = 500 + cx
	sub bx, 1; bx = bx - 1 = 500 + cx - 1
	mov ds, bx; setam coloana ca fiind 500+(cx-1) h
	
	mov [0], ax; punem rezultatul partial ax = a*a*...*a de n ori la adresa 500+(cx-1) h
	

loop calculeaza; scade pe cx cu o unitate. Daca cx este diferit de 0 mergi sus si mai fa odata eticheta calculeaza ... altfel mergi mai departe

hlt