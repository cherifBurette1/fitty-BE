#!/bin/bash
#/c/Users/ashra/.ssh/id_rsa
# Define SSH connection parameters
        serverIP="173.212.215.138"
        keypath="/C/Users/ashra/.ssh/id_rsa"
        username="root"
        # filespath="/D/Projects/IssentialZ-BE/API/bin/Release/net6.0/ubuntu-x64/publish/*"
        filespath="/D/Projects/IssentialZ-BE/API/bin/Debug/net6.0/ubuntu-x64/publish/*"
# cleare repo directory
        ssh "$username@$serverIP" "rm -f /root/repo/*"

# Copy files to a directory on the server
        scp -i "$keypath" $filespath "$username@$serverIP:/root/repo"

# SSH into the server
        ssh -i "$keypath" "$username@$serverIP" /bin/bash << 'EOF'

                # Stop .NET (uncomment if needed)
                         sudo systemctl stop issentialzapi.service

                # redeploy backend (uncomment if needed)
                         sudo rm -rf /var/www/issentialz-api/*
                         sudo mv /root/repo/* /var/www/issentialz-api/*


                # Start .NET and NGINX services (uncomment if needed)
                         sudo systemctl start issentialzapi.service
                         sudo systemctl restart nginx

                # Close SSH session
                        exit
EOF

