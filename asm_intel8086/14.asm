;Vectorul poate avea ce lungime dorim noi(pentru ca nu s-a specificat)
;Desi vector poate fi considerat o singura celula vom lucra cu vectori mai "lungi"

mov cx, 10; vectorul nostru va avea 10 celule in latime
urmatoareaCelula:

	;pentru fiecare celula a vectorului randul va fi constant 5h (sa nu lucram mereu cu 0h)
	;iar DS(coloana) va lua valori de la 500h+10 in jos pana la 500h+1 ... deci 500h+cx pentru ca cx coboara de la 10 la 1
	
	mov ax, 500h
	add ax, cx
	mov ds, ax; ds = 500h + cx
	
	mov [5h], 10h; la randul 5h si coloana specificata mai sus punem valoarea 10h. Atentie 5 in baza 16 (hexa) este acelasi 5 din baza 10 deci nu conteaza daca pun 5h sau 5

loop urmatoareaCelula
hlt