# ============================================================================ #
# Author: Tancredi-Paul Grozav <paul@grozav.info>
# ============================================================================ #
echo "I run." &&

# Disable FrameBuffer(switching to video mode), for both the kernel and GRUB
# Useful for when running the machine in QEMU's curses mode.
sed "/^.*linux.*\/vmlinuz-.* vga=normal /s/ quiet$/ bochs_drm.fbdev=off/" \
  -i /boot/grub/grub.cfg &&
sed "/^terminal_output gfxterm/s/ gfxterm$/ console/" -i /boot/grub/grub.cfg &&

echo "I am done running." &&
exit 0
# ============================================================================ #
