# API de Autenticação - Clinic4Us

Este documento descreve os endpoints de autenticação disponíveis na API.

## Configuração

### appsettings.json

As configurações de JWT já estão configuradas em `appsettings.json`:

```json
{
  "JwtSettings": {
    "Secret": "FederalKeyDifferential_Clinic4Us_@123#",
    "ExpirationHours": 2,
    "Issuer": "Clinic4UsAPI",
    "Audience": "https://localhost"
  }
}
```

## Endpoints

### 1. Registrar Usuário

**POST** `/api/auth/register`

Registra um novo usuário no sistema.

**Request Body:**

```json
{
  "email": "usuario@exemplo.com",
  "password": "SenhaForte@123",
  "confirmPassword": "SenhaForte@123"
}
```

**Response Success (200):**

```json
{
  "message": "Usuário registrado com sucesso!"
}
```

**Validações:**

- Email válido
- Senha com no mínimo 6 caracteres
- Senha deve conter letra maiúscula, minúscula, número e caractere especial
- Senha e confirmação devem ser iguais

---

### 2. Login

**POST** `/api/auth/login`

Autentica um usuário e retorna um token JWT.

**Request Body:**

```json
{
  "email": "usuario@exemplo.com",
  "password": "SenhaForte@123"
}
```

**Response Success (200):**

```json
{
  "accessToken": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...",
  "expiresIn": 7200,
  "userToken": {
    "id": "abc123",
    "email": "usuario@exemplo.com",
    "claims": [
      {
        "type": "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier",
        "value": "abc123"
      },
      {
        "type": "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress",
        "value": "usuario@exemplo.com"
      }
    ]
  }
}
```

**Response Error (400):**

```json
{
  "message": "Usuário ou senha inválidos."
}
```

---

### 3. Alterar Senha

**POST** `/api/auth/change-password`

Altera a senha de um usuário autenticado.

**Headers:**

```
Authorization: Bearer {token}
```

**Request Body:**

```json
{
  "email": "usuario@exemplo.com",
  "currentPassword": "SenhaAntiga@123",
  "newPassword": "SenhaNova@123",
  "confirmNewPassword": "SenhaNova@123"
}
```

**Response Success (200):**

```json
{
  "message": "Senha alterada com sucesso!"
}
```

**Response Error (401):**

```json
{
  "message": "Você não tem permissão para alterar a senha deste usuário."
}
```

---

### 4. Validar Token

**GET** `/api/auth/validate-token`

Valida se o token JWT é válido e retorna informações do usuário.

**Headers:**

```
Authorization: Bearer {token}
```

**Response Success (200):**

```json
{
  "message": "Token válido.",
  "userId": "abc123",
  "email": "usuario@exemplo.com",
  "claims": [
    {
      "type": "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier",
      "value": "abc123"
    }
  ]
}
```

**Response Error (401):**

```json
{
  "message": "Token inválido."
}
```

---

### 5. Obter Usuário Atual

**GET** `/api/auth/me`

Retorna as informações do usuário autenticado.

**Headers:**

```
Authorization: Bearer {token}
```

**Response Success (200):**

```json
{
  "id": "abc123",
  "email": "usuario@exemplo.com",
  "userName": "usuario@exemplo.com"
}
```

**Response Error (401):**

```json
{
  "message": "Usuário não autenticado."
}
```

---

## Como usar o Token

Após o login bem-sucedido, você receberá um `accessToken`. Use este token em todas as requisições que requerem autenticação:

```
Authorization: Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...
```

O token expira em 2 horas (7200 segundos) por padrão.

## Requisitos de Senha

As senhas devem atender aos seguintes requisitos:

- Mínimo de 6 caracteres
- Pelo menos 1 letra maiúscula
- Pelo menos 1 letra minúscula
- Pelo menos 1 número
- Pelo menos 1 caractere especial

## Testando com Swagger

A API possui Swagger configurado. Acesse:

- `http://localhost:5050/swagger`

Para testar endpoints protegidos no Swagger:

1. Faça login através do endpoint `/api/auth/login`
2. Copie o `accessToken` da resposta
3. Clique no botão "Authorize" no topo do Swagger
4. Digite: `Bearer {seu-token-aqui}`
5. Clique em "Authorize"
