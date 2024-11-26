if [ "$(id -u)" -ne "0" ]; then
    echo "Este script precisa ser executado como root."
    exit 1
fi

# Recebe os parâmetros de linha de comando
user=$1
senha=$2

# Verifica se o usuário existe
if id "$user" &>/dev/null; then
    echo "$user:$senha" | sudo chpasswd
    if [ $? -eq 0 ]; then
        echo "Senha alterada com sucesso do usuário '$user'!"
    else
        echo "Falha ao alterar a senha do usuário '$user'!"
    fi
else
    echo "Usuário não encontrado!"
    exit 1
fi
