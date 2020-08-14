mov ax, 500h
mov ds, ax
mov [0], 7

mov ax, 501h
mov ds, ax
mov [0], 5

mov ax, 500h
mov ds, ax
mov ax, [0]

mov bx, 501h
mov ds, bx
mov bx, [0]

mul bx

mov bx, 502h
mov ds, bx
mov [0], ax

hlt