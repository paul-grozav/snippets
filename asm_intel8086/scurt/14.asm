mov cx, 6
p:
    mov ax, 500h
    add ax, cx
    mov ds, ax
    mov [0], 10h
loop p
hlt