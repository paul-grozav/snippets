# ============================================================================ #
# Author: Tancredi-Paul Grozav <paul@grozav.info>
# ============================================================================ #
echo "I run." &&


# Remove unused packages
# ============================================================================ #
echo &&
echo "Removing packages to minimal ..." &&
apt purge -y \
  gnome* *xorg* cpp* desktop-base desktop-file-utils cron geoip-database git \
  git-man libasound2 lxde-common lightdm lightdm-gtk-greeter light-locker lxdm \
  lxsession lxsession-data lxpolkit lxterminal lxmenu-data openbox vim-common \
  vim-tiny x11-common x11-utils xauth xfonts-base xfonts-utils libx11-data \
  libxvmc1 \
  &&
apt -y autoremove &&


# Upgrade system
# ============================================================================ #
echo &&
echo "Upgrading all system packages ..." &&
apt update &&
apt -y upgrade &&
apt -y dist-upgrade &&
apt -y autoremove &&


# Remove unused kernels?
# ============================================================================ #
echo &&
echo "Removing unused kernel packages ..." &&
apt purge $(dpkg -l | grep linux-image | awk '{print$2}' |
  grep "\." | grep -v "linux-image-$(uname -r)")



# Disable FrameBuffer(switching to video mode), for both the kernel and GRUB
# Useful for when running the machine in QEMU's curses mode.
# ============================================================================ #
#echo &&
#echo "Disabling video mode - boot in text only ..." &&
#sed "/^.*linux.*\/vmlinuz-.* vga=normal /s/ quiet$/ bochs_drm.fbdev=off/" \
#  -i /boot/grub/grub.cfg &&
#sed "/^terminal_output gfxterm/s/ gfxterm$/ console/" -i /boot/grub/grub.cfg &&


echo "I am done running." &&
exit 0
# ============================================================================ #
