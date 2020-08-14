mov ax, 501h
mov ds, ax
mov [0], 1

mov ax, 502h
mov ds, ax
mov [0], 6

mov ax, 503h
mov ds, ax
mov [0], 4

mov ax, 504h
mov ds, ax
mov [0], 1

mov ax, 505h
mov ds, ax
mov [0], 4

mov ax, 506h
mov ds, ax
mov [0], 5

mov ax, 0
mov cx, 6
s:
    mov bx, 500h
    add bx, cx
    mov ds, bx
    mov bx, ax
    mov ax, [0]
    mov cx, 2
    div cx
    mov cx, ds
    sub cx, 500h
    mov ax, bx
    cmp dx, 1
    jz i
        add ax, [0]
    i:
loop s
hlt