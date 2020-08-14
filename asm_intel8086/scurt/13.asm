mov ax, 500h
mov ds, ax
mov [0], 1

mov ax, 501h
mov ds, ax
mov [0], 3

mov ax, 502h
mov ds, ax
mov [0], 6

mov ax, 503h
mov ds, ax
mov [0], 7

mov ax, 504h
mov ds, ax
mov [0], 9

mov ax, 505h
mov ds, ax
mov [0], 0

mov ax, 0
mov cx, 6
x:
    mov bx, cx
    sub bx, 1
    add bx, 500h
    mov ds, bx
    mov cx, ax
    mov ax, [0]
    mov bx, 2
    div bx
    mov ax, cx
    mov cx, ds
    sub cx, 500h
    add cx, 1
    cmp dx, 0
    jz p
        add ax, 1
    p:
loop x
hlt