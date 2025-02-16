#!/bin/bash

# Update & Upgrade
sudo apt update && sudo apt upgrade -y

# Install packages
sudo apt install -y firefox net-tools wireshark openssh-server python3 zsh git tmux vim john sqlite3 nmap curl wget dsniff arduino python3-pip


sudo apt install -y python3-scapy

# Enable SSH
sudo systemctl enable --now ssh

# Install Python tools
python3 -m pip install --upgrade pip
python3 -m pip install scapy flask



# Install macof (part of dsniff)
sudo apt install -y dsniff

# Download RockYou wordlist
if [ ! -f "/usr/share/wordlists/rockyou.txt" ]; then
    sudo mkdir -p /usr/share/wordlists
    sudo wget https://github.com/brannondorsey/naive-hashcat/releases/download/data/rockyou.txt -O /usr/share/wordlists/rockyou.txt
fi

sudo apt install -y wireshark

sudo dpkg-reconfigure wireshark-common

sudo usermod -aG wireshark $USER

newgrp wireshark


sh -c "$(curl -fsSL https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"


echo "Installation complete. Remember to manually install BurpSuite"

