mov ax, 501h
mov ds, ax
mov [0], 1
mov [2], 7

mov ax, 502h
mov ds, ax
mov [0], 6
mov [2], 2

mov ax, 503h
mov ds, ax
mov [0], 4
mov [2], 9

mov ax, 504h
mov ds, ax
mov [0], 9
mov [2], 1

mov ax, 505h
mov ds, ax
mov [0], 4
mov [2], 3

mov ax, 506h
mov ds, ax
mov [0], 5
mov [2], 1

mov cx, 6
s:
    mov bx, 500h
    add bx, cx
    mov ds, bx
    mov ax, [0]  
    mov bx, [2]
    mov [0], bx
    mov [2], ax
loop s
hlt