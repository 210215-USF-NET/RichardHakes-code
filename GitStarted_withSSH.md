## D1. Let git know who you are.  I recommend your real name and email you registered on GitHub/BitBucket/GitLab


git config --global user.name "John Doe"

git config --global user.email johndoe@example.com

## D2. Make a public/private key pair for you on this dev system. 

Do this with ssh-keygen (press enter until you get the prompt back).  If you have not already done this, you should see something like this:

$ ssh-keygen

Generating public/private rsa key pair.

Enter file in which to save the key (<home>/.ssh/id_rsa): 

Enter passphrase (empty for no passphrase): 

Enter same passphrase again: 

Your identification has been saved in <home>/.ssh/id_rsa.

Your public key has been saved in <home>/.ssh/id_rsa.pub.

The key fingerprint is:

SHA256:<hash> <user>@<network>

The key's randomart image is:

+---[RSA 2048]----+

|                 |

|      ^-^        |

|     (o-o)       |

|      \ /        |

|       |         |

|                 |

|                 |

|                 |

|                 |

+----[SHA256]-----+

$ 

If you already have one on this system, you should see something like this (your old key won’t be erased or changed)

$ ssh-keygen

Generating public/private rsa key pair.

Enter file in which to save the key (<home>/.ssh/id_rsa): 

<home>/.ssh/id_rsa already exists.

Overwrite (y/n)? 

$ 


## D3. Share the public part of the key with github.  First copy the generated public key to the clipboard (system dependent):

cat ~/.ssh/id_rsa.pub | clip                         # windows

cat ~/.ssh/id_rsa.pub | pbcopy                       # mac



sudo apt-get install -y xclip                        # install the xclip tool on linux

cat ~/.ssh/id_rsa.pub | xclip -selection c           # linux


Now add the public key to the allowed keys for your user (under settings in Github), just paste what you just put in the clipboard as a new public 
key.  To get to your settings click on your github avatar on your dashboard page https://github.com/<user>:


	
Then “SSH and GPG keys” followed by “New SSH Key”





You will be asked to confirm your password, then be allowed to add a key (which is still in your clipboard from the “copy the generated public 
key” step above).  Give it a descriptive name like “my laptop” so you know where it is from.


