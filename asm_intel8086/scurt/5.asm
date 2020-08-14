mov cx, 5
mov ax, 1
p:
    mul cx
    
    mov bx, 500h
    add bx, cx
    mov ds, bx
    mov [0], ax
loop p
hlt